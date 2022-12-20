using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(product => product.ProductId);
        builder.HasIndex(product => product.ProductId).IsUnique();
        builder.Property(product => product.ProductName).IsRequired().HasMaxLength(30);
        builder.Property(product => product.Description).HasMaxLength(250);
        builder.Property(product => product.Price).HasPrecision(9, 2);

        builder.HasOne(product => product.User).WithMany(user => user.Products);
        builder.HasOne(product => product.Brand).WithMany(brand => brand.Products);
        builder.HasMany(product => product.Colors).WithMany(color => color.Products);
        builder.HasOne(product => product.Gender).WithMany(gender => gender.Products);
        builder.HasMany(product => product.Seasons).WithMany(season => season.Products);
    }
}