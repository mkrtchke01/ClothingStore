
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedLocations : IEntityTypeConfiguration<Location>
    {
        private List<Location> Locations = new()
        {
            new Location() { LocationId = 1, Country = "Беларусь", City = "Витебск", Index = "210021", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Location() { LocationId = 2, Country = "Россия", City = "Москва", Index = "210021", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Location() { LocationId = 3, Country = "Украина", City = "Киев", Index = "210021", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Location() { LocationId = 4, Country = "Беларусь", City = "Могилев", Index = "210021", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Location() { LocationId = 5, Country = "Беларусь", City = "Минск", Index = "210021", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
        };
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(Locations);
        }
    }
}
