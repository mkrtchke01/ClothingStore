namespace ClothingStore.Domain;

public class Gender : BaseModel
{
    public int GenderId { get; set; }
    public string GenderName { get; set; }
    public ICollection<Product> Products { get; set; }
}