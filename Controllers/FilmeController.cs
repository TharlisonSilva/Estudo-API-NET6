using Estudo_API_NET6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo_API_NET6.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionarFilme([FromBody]Filme filme)
    {
        filmes.Add(filme);
    }

    [HttpGet]
    public List<Filme> RecuperarFilmes()
    {
        return filmes;
    }

    [HttpPost]
    public Filme RecuperarFilmesById(string idFilme)
    {
        return filmes.Find(x => x.IdFilme == idFilme);
    }
}