using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.HasKey(color => color.ColorId);
        builder.HasIndex(color => color.ColorId).IsUnique();
        builder.Property(color => color.ColorName).IsRequired().HasMaxLength(35);

        builder.HasMany(color => color.Products).WithMany(product => product.Colors);
    }
}