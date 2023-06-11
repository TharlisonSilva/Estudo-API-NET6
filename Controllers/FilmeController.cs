using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody]Filme filme)
    {
        filmes.Add(filme);
        Console.WriteLine(filme.ID);
        return CreatedAtAction(nameof(RecuperarFilmePorId), new { id = filme.ID}, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilmes([FromQuery] int skyp=0, [FromQuery] int take=50)
    {
        return filmes.Skip(skyp).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(string id)
    {
        var filme =  filmes.FirstOrDefault(filme => filme.ID == id);
        if(filme == null)
            return NotFound();
        return Ok(filme);
    }

}