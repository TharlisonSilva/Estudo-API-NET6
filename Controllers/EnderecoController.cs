
using AutoMapper;
using Estudo_API_NET6.Data.Context;
using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public EnderecoController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
    {
        Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
        _context.Add(endereco);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarEnderecoPorId), new { id = endereco.Id}, endereco);
    }

    [HttpGet]
    public IEnumerable<ReadEnderecoDto> RecuperarEnderecos([FromQuery] int skip=0, [FromQuery] int take=50)
    {
        return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.Skip(skip).Take(take));
    }


    [HttpGet("{id}")]
    public IActionResult RecuperarEnderecoPorId(string id)
    {
        var endereco =  _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
        if(endereco == null)
            return NotFound();
        var enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
        return Ok(enderecoDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarEndereco(String id, [FromBody]UpdateEnderecoDto enderecoDto)
    {
        var endereco = _context.Enderecos.FirstOrDefault(item => item.Id == id);
        if(endereco == null) 
            return NotFound();
        _mapper.Map(enderecoDto, endereco);   
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarEndereco(String id)
    {
        var endereco = _context.Enderecos.FirstOrDefault(item => item.Id == id);
        if(endereco == null) 
            return NotFound();
            
        _context.Remove(endereco);
        _context.SaveChanges();
        return NoContent();
    }

}
