using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadCinemaDto
{
    public string? Id { get; set; } 
    public string? Nome { get; set; }
    public ReadEnderecoDto Endereco { get; set; } = null!;
    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;

}