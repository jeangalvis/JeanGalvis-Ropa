using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class TallaConfiguration : IEntityTypeConfiguration<Talla>
{
    public void Configure(EntityTypeBuilder<Talla> builder)
    {
        builder.ToTable("talla");
    }
}
