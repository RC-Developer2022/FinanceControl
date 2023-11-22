using FinancaControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Settings;

public sealed class CustomersDbSettings : IEntityTypeConfiguration<Customers>
{
    public void Configure(EntityTypeBuilder<Customers> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c => c.Id).Metadata.IsPrimaryKey();
        builder.Property(c => c.Id).HasColumnName("ClienteId").ValueGeneratedOnAdd();
        builder.Property(c => c.Name).HasColumnName("Nome").HasMaxLength(180);
        builder.Property(c => c.Phone).HasColumnName("Telefone");
        builder.Property(c => c.Discount).HasColumnName("Desconto");
        builder.Property(c => c.ExpiryDate).HasColumnName("DataVencimento");
        builder.Property(c => c.Recommendation).HasColumnName("Indicacao");
        builder.Property(c => c.Observation).HasColumnName("Observacao");
    }
}
