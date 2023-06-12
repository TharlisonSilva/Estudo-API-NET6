using Estudo_API_NET6.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudo_API_NET6.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
        
    }

    public DbSet<Filme> Filmes { get; set;}
}