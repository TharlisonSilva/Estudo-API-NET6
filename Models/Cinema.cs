using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Models;
public class Cinema
{
    [Key]
    [Required]
    public string? Id{ get; internal set; }

    [Required(ErrorMessage = "O nome do cinema é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho maximo do nome é 50 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O ID do endereço é obrigatorio")]
    public string EnderecoId { get; set; } = null!;
    public virtual Endereco Endereco { get; set; } = null!;

    public Cinema()
    {
        this.Id = Guid.NewGuid().ToString();
    }

}