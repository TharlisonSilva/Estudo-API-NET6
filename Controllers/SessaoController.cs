
using AutoMapper;
using Estudo_API_NET6.Data.Context;
using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class SessaoController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public SessaoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarSessao([FromBody] CreateSessaoDto sessaoDto)
    {
        Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
        _context.Add(sessao);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarSessaoPorId), new { id = sessao.Id}, sessao);
    }

    [HttpGet]
    public IEnumerable<ReadSessaoDto> RecuperarSessoes([FromQuery] int skip=0, [FromQuery] int take=50)
    {
        return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.Skip(skip).Take(take).ToList());
    }


    [HttpGet("{id}")]
    public IActionResult RecuperarSessaoPorId(string id)
    {
        var sessao =  _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
        if(sessao == null)
            return NotFound();
        var sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
        return Ok(sessaoDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarSessao(String id, [FromBody]UpdateSessaoDto sessaoDto)
    {
        var sessao = _context.Sessoes.FirstOrDefault(item => item.Id == id);
        if(sessao == null) 
            return NotFound();
        _mapper.Map(sessaoDto, sessao);   
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarSessao(String id)
    {
        var sessao = _context.Sessoes.FirstOrDefault(item => item.Id == id);
        if(sessao == null) 
            return NotFound();
        
        _context.Remove(sessao);
        _context.SaveChanges();   
        return NoContent();
    }

}
