namespace ClothingStore.Domain;

public class Product : BaseModel
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Season> Seasons { get; set; }

    public int GenderId { get; set; }
    public Gender Gender { get; set; }

    public ICollection<Color> Colors { get; set; }

    public int BrandId { get; set; }
    public Brand Brand { get; set; }
}