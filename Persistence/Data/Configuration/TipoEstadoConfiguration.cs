using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class TipoEstadoConfiguration : IEntityTypeConfiguration<TipoEstado>
{
    public void Configure(EntityTypeBuilder<TipoEstado> builder)
    {
        builder.ToTable("tipoEstado");
    }
}
