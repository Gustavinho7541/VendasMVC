using Microsoft.EntityFrameworkCore;

namespace VendasMvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Adicione seus DbSets aqui, ex:
    // public DbSet<Venda> Vendas { get; set; }
    // public DbSet<VendaProduto> VendaProdutos { get; set; }
}