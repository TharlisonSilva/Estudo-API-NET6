using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadFilmeDto
{

    public string? TITULO { get; set; }

    public string? GENERO { get; set; }

    public int DURACAO { get; set; }

    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;

}