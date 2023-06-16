using System.Runtime.CompilerServices;
using AutoMapper;
using Estudo_API_NET6.Data.Context;
using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context; 
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody]CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarFilmePorId), new { id = filme.Id}, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperarFilmes([FromQuery] int skip=0, [FromQuery] int take=50)
    {
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(string id)
    {
        var filme =  _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if(filme == null)
            return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        return Ok(filmeDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarFilme(String id, [FromBody]UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(item => item.Id == id);
        if(filme == null) 
            return NotFound();
        _mapper.Map(filmeDto, filme);   
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizarFilmeParcial(String id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        var filme = _context.Filmes.FirstOrDefault(item => item.Id == id);
        if(filme == null) 
            return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if(!TryValidateModel(filmeParaAtualizar))
            return ValidationProblem(ModelState);
        

        _mapper.Map(filmeParaAtualizar, filme);   
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarFilme(String id)
    {
        var filme = _context.Filmes.FirstOrDefault(item => item.Id == id);
        if(filme == null) 
            return NotFound();
            
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }

}