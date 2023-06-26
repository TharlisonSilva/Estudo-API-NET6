
using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadEnderecoDto
{
    public string? Id { get; set; }
    public string? Logradouro { get; set; }
    public string? Numero { get; set; }
    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;
}