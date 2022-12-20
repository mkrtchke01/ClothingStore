using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasKey(location => location.LocationId);
        builder.HasIndex(location => location.LocationId).IsUnique();
        builder.Property(location => location.Country).IsRequired().HasMaxLength(30);
        builder.Property(location => location.City).IsRequired().HasMaxLength(30);

        builder.HasMany(location => location.Users).WithOne(user => user.Location);
    }
}