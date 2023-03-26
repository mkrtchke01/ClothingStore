
using ClothingStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClothingStore.Persistence.SeedData
{
    internal class SeedColors : IEntityTypeConfiguration<Color>
    {
        private List<Color> Colors = new()
        {
            new Color() { ColorId = 1, ColorName = "Белый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now}, new Color() { ColorId = 2, ColorName = "Черный" , CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now},
            new Color() {ColorId = 3,  ColorName = "Желтый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Color() { ColorId = 4, ColorName = "Коричневый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Color() { ColorId = 5, ColorName = "Розовый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Color() { ColorId = 6, ColorName = "Бежевый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Color() { ColorId = 7, ColorName = "Серый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Color() { ColorId = 8, ColorName = "Зеленый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Color() { ColorId = 9, ColorName = "Синий", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Color() { ColorId = 10, ColorName = "Фиолетовый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
            new Color() { ColorId = 11, ColorName = "Красный", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }, new Color() { ColorId = 12, ColorName = "Оранжевый", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
        };
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(Colors);
        }
    }
}
