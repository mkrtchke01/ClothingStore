namespace ClothingStore.Domain;

public class Brand : BaseModel
{
    public int BrandId { get; set; }
    public string BrandName { get; set; }
    public ICollection<Product> Products { get; set; }
}