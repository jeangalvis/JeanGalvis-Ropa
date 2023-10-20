using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class VentaConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("venta");

        builder.HasOne(p => p.Empleado)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.IdEmpleadofk);

        builder.HasOne(p => p.Cliente)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.IdClientefk);

        builder.HasOne(p => p.FormaPago)
        .WithMany(p => p.Ventas)
        .HasForeignKey(p => p.IdFormaPagofk);
    }
}
