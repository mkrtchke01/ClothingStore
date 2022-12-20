namespace ClothingStore.Domain;

public class Location : BaseModel
{
    public int LocationId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Index { get; set; }
    public ICollection<User> Users { get; set; }
}