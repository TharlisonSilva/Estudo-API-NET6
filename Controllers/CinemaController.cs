
using AutoMapper;
using Estudo_API_NET6.Data.Context;
using Estudo_API_NET6.Data.DTOs;
using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class CinemaController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public CinemaController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarCinema([FromBody] CreateCinemaDto cinemaDto)
    {
        Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
        _context.Add(cinema);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarCinemaPorId), new { id = cinema.Id}, cinema);
    }

    [HttpGet]
    public IEnumerable<ReadCinemaDto> RecuperarCinemas([FromQuery] int skip=0, [FromQuery] int take=50)
    {
        return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.Skip(skip).Take(take));
    }


    [HttpGet("{id}")]
    public IActionResult RecuperarCinemaPorId(string id)
    {
        var cinema =  _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        if(cinema == null)
            return NotFound();
        var cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
        return Ok(cinemaDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarCinema(String id, [FromBody]UpdateCinemaDto cinemaDto)
    {
        var cinema = _context.Cinemas.FirstOrDefault(item => item.Id == id);
        if(cinema == null) 
            return NotFound();
        _mapper.Map(cinemaDto, cinema);   
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarCinema(String id)
    {
        var cinema = _context.Cinemas.FirstOrDefault(item => item.Id == id);
        if(cinema == null) 
            return NotFound();
        
        _context.Remove(cinema);
        _context.SaveChanges();   
        return NoContent();
    }

}
