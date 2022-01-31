using Microsoft.EntityFrameworkCore;

namespace ProdutosCrud.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {}
        public DbSet<Produto>? Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Produto>().HasKey(c => c.ProdutoId);
            mb.Entity<Produto>().Property(c => c.ProdutoNome).HasMaxLength(150);
            mb.Entity<Produto>().Property(c => c.Imagem).HasMaxLength(250);
            mb.Entity<Produto>().Property(c => c.Preco).HasPrecision(14, 2);
        }
    }
}
