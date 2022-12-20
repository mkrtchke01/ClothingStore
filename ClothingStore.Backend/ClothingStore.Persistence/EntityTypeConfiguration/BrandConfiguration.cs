using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasKey(brand => brand.BrandId);
        builder.HasIndex(brand => brand.BrandId).IsUnique();
        builder.Property(brand => brand.BrandName).IsRequired().HasMaxLength(35);

        builder.HasMany(brand => brand.Products).WithOne(product => product.Brand);
    }
}