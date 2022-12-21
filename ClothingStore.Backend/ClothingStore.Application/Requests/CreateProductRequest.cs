namespace ClothingStore.Application.Requests;

public class CreateProductRequest
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public ICollection<string> SeasonNames { get; set; }
    public string GenderName { get; set; }

    public ICollection<string> ColorNames { get; set; }

    public string BrandName { get; set; }
}