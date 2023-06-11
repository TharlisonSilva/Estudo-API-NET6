using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Models;
public class Filme
{
    [Key]
    public string? ID{ get; internal set; }

    [Required(ErrorMessage = "O Titulo do filme é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho maximo do titulo é 50 caracteres")]
    public string? TITULO { get; set; }

    [Required(ErrorMessage = "O genêro do filme é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho maximo do genêro é 50 caracteres")]
    public string? GENERO { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatorio")]
    [Range(50, 600, ErrorMessage = "Um filme deve ter duração de 50 a 600 minutos")]
    public int DURACAO { get; set; }
    
    public Filme()
    {
        var uuid = Guid.NewGuid().ToString();
        this.ID = uuid;
    }

}