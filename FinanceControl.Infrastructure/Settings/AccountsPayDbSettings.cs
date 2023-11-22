using FinancaControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Settings;

public sealed class AccountsPayDbSettings : IEntityTypeConfiguration<AccountsPay>
{
    public void Configure(EntityTypeBuilder<AccountsPay> builder)
    {
        builder.ToTable("ContasPagar");
        builder.HasKey(p => p.Id).Metadata.IsPrimaryKey();
        builder.Property(p => p.Id).HasColumnName("ContasPagarId");
        builder.Property(p => p.Pay).HasColumnName("Pago").HasColumnType("bool");
        builder.Property(p => p.Supplier).HasColumnName("Fornecedor");
        builder.Property(p => p.Value).HasColumnName("Valor");
        builder.Property(p => p.ExpiryDate).HasColumnName("DataVencimento");
    }
}
