using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ClothingStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ClothingStoreControllerBase : ControllerBase
    {
        protected string UserId => User.FindFirstValue(JwtRegisteredClaimNames.Sub);
    }
}
