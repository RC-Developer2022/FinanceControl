using FinancaControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure;

public sealed class FinanceDbContext : DbContext
{

    public DbSet<Customers> Customers { get; set; }
    public DbSet<Servers> Servers { get; set; }
    public DbSet<AccountsReceive> AccountsReceive { get; set; }
    public DbSet<AccountsPay> AccountsPay { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FinanceDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Financas.db");
}
