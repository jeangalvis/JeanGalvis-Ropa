using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.ToTable("estado");

        builder.HasOne(p => p.TipoEstado)
        .WithMany(p => p.Estados)
        .HasForeignKey(p => p.IdTipoEstadofk);
    }
}
