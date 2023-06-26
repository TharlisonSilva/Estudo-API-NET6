using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class UpdateSessaoDto
{

    [Required]
    public string? Id { get; set; }
}