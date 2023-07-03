using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Estudo_API_NET6.Models;
public class Filme
{
    [Key]
    [Required]
    public string? Id{ get; internal set; }

    [Required(ErrorMessage = "O Titulo do filme é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho maximo do titulo é 50 caracteres")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O genêro do filme é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho maximo do genêro é 50 caracteres")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatorio")]
    [Range(50, 600, ErrorMessage = "Um filme deve ter duração de 50 a 600 minutos")]
    public int Duracao { get; set; }
    public virtual ICollection<Sessao> Sessoes {get; set;} = null!;
    
    public Filme()
    {
        this.Id = Guid.NewGuid().ToString();
    }

}