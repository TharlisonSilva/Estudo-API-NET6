using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadFilmeDto
{

    public string? Titulo { get; set; }

    public string? Genero { get; set; }

    public int Duracao { get; set; }

    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;

}