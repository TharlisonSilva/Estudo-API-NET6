
using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class CreateEnderecoDto
{
    [Required(ErrorMessage = "O logradouro do cinema é obrigatorio")]
    [StringLength(150, ErrorMessage = "O tamanho maximo do logradouro é 150 caracteres")]
    public string? LOGRADOURO { get; set; }

    [Required(ErrorMessage = "O número é obrigatorio")]
    [StringLength(5, ErrorMessage = "O tamanho maximo do número é 5 caracteres")]
    public string? NUMERO { get; set; }
}