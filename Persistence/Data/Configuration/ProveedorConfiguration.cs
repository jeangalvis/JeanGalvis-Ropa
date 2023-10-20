using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("proveedor");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Proveedores)
        .HasForeignKey(p => p.IdTipoPersonafk);

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Proveedores)
        .HasForeignKey(p => p.IdMunicipiofk);

        builder
       .HasMany(p => p.Insumos)
       .WithMany(r => r.Proveedores)
       .UsingEntity<InsumoProveedor>(

           j => j
           .HasOne(pt => pt.Insumo)
           .WithMany(t => t.InsumoProveedores)
           .HasForeignKey(ut => ut.IdInsumofk),

           j => j
           .HasOne(et => et.Proveedor)
           .WithMany(et => et.InsumoProveedores)
           .HasForeignKey(el => el.IdProveedorfk),

           j =>
           {
               j.ToTable("userRol");
               j.HasKey(t => new { t.IdProveedorfk, t.IdInsumofk });

           });
    }
}
