using FinancaControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Settings;

public sealed class AccountsReceiveDbSettings : IEntityTypeConfiguration<AccountsReceive>
{
    public void Configure(EntityTypeBuilder<AccountsReceive> builder)
    {
        builder.ToTable("ContasReceber");
        builder.HasKey(r => r.Id).Metadata.IsPrimaryKey();
        builder.Property(r => r.Id).HasColumnName("ContasReceberId").ValueGeneratedOnAdd();
        builder.Property(r => r.Value).HasColumnName("Valor");
        builder.Property(r => r.ExpiryDate).HasColumnName("DataVencimento");
        builder.Property(r => r.Received).HasColumnName("Recebido");
        builder.Property(r => r.CustomerId).HasColumnName("ClienteId").Metadata.IsForeignKey();
    }
}
