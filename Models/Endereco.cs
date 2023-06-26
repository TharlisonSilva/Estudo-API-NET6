using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Models;
public class Endereco
{
    [Key]
    [Required]
    public string? Id{ get; internal set; }

    [Required(ErrorMessage = "O logradouro do cinema é obrigatorio")]
    [MaxLength(150, ErrorMessage = "O tamanho maximo do logradouro é 150 caracteres")]
    public string? Logradouro { get; set; }

    [Required(ErrorMessage = "O número é obrigatorio")]
    [MaxLength(5, ErrorMessage = "O tamanho maximo do número é 5 caracteres")]
    public string? Numero { get; set; }
    public virtual Cinema Cinema {get; set;} = null!;

    public Endereco()
    {
        this.Id = Guid.NewGuid().ToString();
    }

}