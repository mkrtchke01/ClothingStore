using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class SeasonConfiguration : IEntityTypeConfiguration<Season>
{
    public void Configure(EntityTypeBuilder<Season> builder)
    {
        builder.HasKey(season => season.SeasonId);
        builder.HasIndex(season => season.SeasonId).IsUnique();
        builder.Property(season => season.SeasonName).IsRequired().HasMaxLength(20);

        builder.HasMany(season => season.Products).WithMany(product => product.Seasons);
    }
}