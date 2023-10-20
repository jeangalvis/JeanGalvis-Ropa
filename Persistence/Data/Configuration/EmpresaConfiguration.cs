using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("empresa");

        builder.HasOne(p => p.Municipio)
        .WithMany(p => p.Empresas)
        .HasForeignKey(p => p.IdMunicipiofk);
    }
}
