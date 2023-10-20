using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("detalleVenta");

        builder.HasOne(p => p.Venta)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.IdVentafk);

        builder.HasOne(p => p.Inventario)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.IdInventariofk);

        builder.HasOne(p => p.Talla)
        .WithMany(p => p.DetalleVentas)
        .HasForeignKey(p => p.IdTallafk);
    }
}
