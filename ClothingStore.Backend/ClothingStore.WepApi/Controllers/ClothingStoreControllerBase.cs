using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class ClothingStoreControllerBase : ControllerBase
{
    protected string UserId => User.FindFirstValue(JwtRegisteredClaimNames.Sub);
}