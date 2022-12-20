namespace ClothingStore.Domain;

public class Season : BaseModel
{
    public int SeasonId { get; set; }
    public string SeasonName { get; set; }
    public ICollection<Product> Products { get; set; }
}