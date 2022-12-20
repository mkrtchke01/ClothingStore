namespace ClothingStore.Domain;

public class User : BaseModel
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public ICollection<Product> Products { get; set; }
}