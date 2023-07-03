using System.ComponentModel.DataAnnotations;
using Estudo_API_NET6.Models;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadSessaoDto
{

    public string? Id { get; set; }
    public string FilmeId {get; set;} = null!;
    public virtual Filme Filme {get; set;} = null!;
    public string CinemaId {get; set;} = null!;
    public virtual Cinema Cinema {get; set;} = null!;

}