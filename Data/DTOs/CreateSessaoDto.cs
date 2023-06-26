
using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class CreateSessaoDto
{
    [Required]
    public string? FilmeId {get; set;}
}