using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("inventario");

        builder.HasOne(p => p.Prenda)
        .WithMany(p => p.Inventarios)
        .HasForeignKey(p => p.IdPrendafk);
    }
}
