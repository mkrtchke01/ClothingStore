using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.EntityTypeConfiguration;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.UserId);
        builder.HasIndex(user => user.UserId).IsUnique();
        builder.Property(user => user.UserName).IsRequired().HasMaxLength(25);

        builder.HasOne(user => user.Location).WithMany(location => location.Users);
        builder.HasMany(user => user.Products).WithOne(product => product.User);
    }
}