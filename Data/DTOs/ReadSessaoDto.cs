namespace Estudo_API_NET6.Data.DTOs;

public class ReadSessaoDto
{

    public string? Id { get; set; }
    public virtual ReadFilmeDto Filme {get; set;} = null!;
    public virtual ReadCinemaDto Cinema {get; set;} = null!;

}