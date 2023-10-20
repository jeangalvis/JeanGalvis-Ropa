using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {
        builder.ToTable("prenda");

        builder.HasOne(p => p.Estado)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdEstadofk);

        builder.HasOne(p => p.TipoProteccion)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdTipoProteccionfk);

        builder.HasOne(p => p.Genero)
        .WithMany(p => p.Prendas)
        .HasForeignKey(p => p.IdGenerofk);
    }
}
