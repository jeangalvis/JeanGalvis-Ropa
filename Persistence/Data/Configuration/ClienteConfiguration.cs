using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("cliente");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.IdTipoPersonafk);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Clientes)
        .HasForeignKey(p => p.IdMunicipiofk);
    }
}
