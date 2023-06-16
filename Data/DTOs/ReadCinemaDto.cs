using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadCinemaDto
{
    public string? ID { get; set; } 
    public string? NOME { get; set; }
    public ReadEnderecoDto READENDERECODTO { get; set; } = null!;
    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;

}