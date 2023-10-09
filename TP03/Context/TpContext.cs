using Microsoft.EntityFrameworkCore;
using TP03.Models.Entity;

namespace TP03.Context;

public class TpContext : DbContext
{
    public TpContext(DbContextOptions<TpContext> options) : base(options)
    {
    }
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Produto>().HasKey(m => m.Id);

        base.OnModelCreating(builder);
    }
}
