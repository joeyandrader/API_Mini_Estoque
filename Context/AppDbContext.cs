using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<CategoriaModel>? Categorias { get; set; }
        public DbSet<ProdutoModel>? Produtos { get; set; }
    }
}