
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedUsers : IEntityTypeConfiguration<User>
    {
        private List<User> Users = new()
        {
            new User() { Id = "3046bb27-a9f9-4cfb-87ee-0853cae48701", LocationId = 1, UserName = "mkr.e", PasswordHash = "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", SecurityStamp = "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", ConcurrencyStamp = "b84f97b2-007f-4781-9ee7-9dcedd5185d3", RefreshToken = "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", RefreshTokenExpiryTime = DateTime.Now.AddDays(1) },
            new User() { Id = "3046bb27-a9f9-4cfb-87ee-0853cae48702", LocationId = 2, UserName = "Andrey", PasswordHash = "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", SecurityStamp = "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", ConcurrencyStamp = "b84f97b2-007f-4781-9ee7-9dcedd5185d3", RefreshToken = "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", RefreshTokenExpiryTime = DateTime.Now.AddDays(1) },
            new User() { Id = "3046bb27-a9f9-4cfb-87ee-0853cae48703", LocationId = 3, UserName = "Vitali", PasswordHash = "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", SecurityStamp = "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", ConcurrencyStamp = "b84f97b2-007f-4781-9ee7-9dcedd5185d3", RefreshToken = "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", RefreshTokenExpiryTime = DateTime.Now.AddDays(1) },
            new User() { Id = "3046bb27-a9f9-4cfb-87ee-0853cae48704", LocationId = 4, UserName = "Alexandr", PasswordHash = "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", SecurityStamp = "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", ConcurrencyStamp = "b84f97b2-007f-4781-9ee7-9dcedd5185d3", RefreshToken = "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", RefreshTokenExpiryTime = DateTime.Now.AddDays(1) },
            new User() { Id = "3046bb27-a9f9-4cfb-87ee-0853cae48705", LocationId = 5, UserName = "Vasilisa", PasswordHash = "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", SecurityStamp = "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", ConcurrencyStamp = "b84f97b2-007f-4781-9ee7-9dcedd5185d3", RefreshToken = "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", RefreshTokenExpiryTime = DateTime.Now.AddDays(1) }
        };
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(Users);
        }
    }
}
