
using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class UpdateEnderecoDto
{
    [Required(ErrorMessage = "O logradouro do cinema é obrigatorio")]
    [StringLength(150, ErrorMessage = "O tamanho maximo do logradouro é 150 caracteres")]
    public string? Logradouro { get; set; }

    [Required(ErrorMessage = "O número é obrigatorio")]
    [StringLength(5, ErrorMessage = "O tamanho maximo do número é 5 caracteres")]
    public string? Numero { get; set; }
}