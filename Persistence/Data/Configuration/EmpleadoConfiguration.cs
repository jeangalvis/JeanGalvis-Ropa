using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("empleado");

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.IdMunicipiofk);

        builder.HasOne(p => p.Cargo)
        .WithMany(p => p.Empleados)
        .HasForeignKey(p => p.IdCargofk);
    }
}
