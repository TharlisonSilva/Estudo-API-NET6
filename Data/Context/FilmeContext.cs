using Estudo_API_NET6.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudo_API_NET6.Data.Context;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
        
    }
    public DbSet<Filme> Filmes { get; set;} = null!;
    public DbSet<Cinema> Cinemas { get; set;} = null!;
    public DbSet<Endereco> Enderecos { get; set;} = null!;
}