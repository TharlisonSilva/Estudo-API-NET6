using System.ComponentModel.DataAnnotations;

namespace Estudo_API_NET6.Models;

public class Sessao{

    [Key]
    [Required]
    public string Id{get; set;}

    [Required]
    public string FilmeId {get; set;} = null!;
    public virtual Filme Filme {get; set;} = null!;
    [Required]
    public string CinemaId {get; set;} = null!;
    public virtual Cinema Cinema {get; set;} = null!;

    public Sessao(){
        this.Id = Guid.NewGuid().ToString();
    }

}