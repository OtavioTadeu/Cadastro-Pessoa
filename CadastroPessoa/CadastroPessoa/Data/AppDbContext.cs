using CadastroPessoa.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoa.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }
    DbSet<Pessoa> Pessoas { get; set; } = null!;
}

