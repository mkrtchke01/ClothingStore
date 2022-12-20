using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class GenderConfiguration : IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.HasKey(gender => gender.GenderId);
        builder.HasIndex(gender => gender.GenderId).IsUnique();
        builder.Property(gender => gender.GenderName).IsRequired().HasMaxLength(20);

        builder.HasMany(gender => gender.Products).WithOne(product => product.Gender);
    }
}