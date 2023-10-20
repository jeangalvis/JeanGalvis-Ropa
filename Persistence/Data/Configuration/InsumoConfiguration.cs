using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("insumo");
    }
}
