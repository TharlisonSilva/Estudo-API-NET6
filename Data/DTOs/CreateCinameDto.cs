using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O nome do cinema é obrigatorio")]
    [StringLength(50, ErrorMessage = "O tamanho maximo do nome é 50 caracteres")]
    public string? NOME { get; set; }
    public string? ENDERECO_ID { get; set; }

}