
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedSeasons : IEntityTypeConfiguration<Season>
    {
        private List<Season> Seasons = new()
        {
            new Season() { SeasonId = 1, SeasonName = "Демисезон", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Season() { SeasonId = 2, SeasonName = "Весна", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Season() { SeasonId = 3, SeasonName = "Зима", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Season() { SeasonId = 4, SeasonName = "Осень", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Season() { SeasonId = 5, SeasonName = "Лето", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
        };
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasData(Seasons);
        }
    }
}
