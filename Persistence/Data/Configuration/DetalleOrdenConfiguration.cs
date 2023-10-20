using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("detalleOrden");

        builder.HasOne(p => p.Orden)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.IdOrdenfk);

        builder.HasOne(p => p.Prenda)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.IdPrendafk);

        builder.HasOne(p => p.Color)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.IdColorfk);
    
        builder.HasOne(p => p.Estado)
        .WithMany(p => p.DetalleOrdenes)
        .HasForeignKey(p => p.IdEstadofk);
    }
}
