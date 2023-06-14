using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Data.DTOs;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O Titulo do filme é obrigatorio")]
    [StringLength(50, ErrorMessage = "O tamanho maximo do titulo é 50 caracteres")]
    public string? TITULO { get; set; }

    [Required(ErrorMessage = "O genêro do filme é obrigatorio")]
    [StringLength(50, ErrorMessage = "O tamanho maximo do genêro é 50 caracteres")]
    public string? GENERO { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatorio")]
    [Range(50, 600, ErrorMessage = "Um filme deve ter duração de 50 a 600 minutos")]
    public int DURACAO { get; set; }

}