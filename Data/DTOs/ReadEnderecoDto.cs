
using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadEnderecoDto
{
    public string? ID { get; set; }
    public string? LOGRADOURO { get; set; }
    public string? NUMERO { get; set; }
}