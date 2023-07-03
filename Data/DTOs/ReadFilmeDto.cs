using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Estudo_API_NET6.Data.DTOs;

public class ReadFilmeDto
{

    public string? Id{ get; internal set; }
    public string? Titulo { get; set; }

    public string? Genero { get; set; }

    public int Duracao { get; set; }
    public virtual ICollection<ReadSessaoDto> Sessoes {get; set;} = null!;
    public DateTime HoraDaConsulta{get; set; } = DateTime.Now;

}