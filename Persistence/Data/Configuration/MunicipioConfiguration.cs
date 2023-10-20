using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
{
    public void Configure(EntityTypeBuilder<Municipio> builder)
    {
        builder.ToTable("municipio");

        builder.HasOne(p => p.Departamento)
        .WithMany(p => p.Municipios)
        .HasForeignKey(p => p.IdDepartamentofk);
    }
}
