namespace ClothingStore.Domain;

public class Color : BaseModel
{
    public int ColorId { get; set; }
    public string ColorName { get; set; }
    public ICollection<Product> Products { get; set; }
}