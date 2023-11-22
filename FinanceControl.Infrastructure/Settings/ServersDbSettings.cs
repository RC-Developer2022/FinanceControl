using FinancaControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Settings;

public sealed class ServersDbSettings : IEntityTypeConfiguration<Servers>
{
    public void Configure(EntityTypeBuilder<Servers> builder)
    {
        builder.ToTable("Servidores");
        builder.HasKey(s => s.Id).Metadata.IsPrimaryKey();
        builder.Property(s => s.Id).HasColumnName("ServidorId").ValueGeneratedOnAdd();
        builder.Property(s => s.Name).HasColumnName("NomeServidor");
        builder.Property(s => s.Site).HasColumnName("Site");
        builder.Property(s => s.Contact).HasColumnName("Contato");
        builder.Property(s => s.Observation).HasColumnName("Observacao");
    }
}
