using Microsoft.EntityFrameworkCore;
using teste.Shared.Models;

namespace teste.Server.Context;

    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    { }

    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Produto>? Produtos { get; set; }   

    }

