using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Domain;

public class User : IdentityUser
{
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public ICollection<Product> Products { get; set; }
}