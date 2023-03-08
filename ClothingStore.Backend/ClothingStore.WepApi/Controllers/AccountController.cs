using ClothingStore.Application.Common.Jwt;
using ClothingStore.Application.Mediator.Account.Commands.Login;
using ClothingStore.Application.Mediator.Account.Commands.Register;
using ClothingStore.Application.Requests;
using ClothingStore.Application.Responses;
using ClothingStore.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ClothingStoreControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ITokenService _tokenService;
        private readonly UserManager<User> _userManager;

        public AccountController(IMediator mediator, ITokenService tokenService, UserManager<User> userManager)
        {
            _mediator = mediator;
            _tokenService = tokenService;
            _userManager = userManager;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("signIn")]
        public async Task<IActionResult> SignIn(LoginRequest loginRequest)
        {
            var result = await _mediator.Send(new LoginCommand
            {
                UserName = loginRequest.UserName,
                Password = loginRequest.Password
            });
            return Ok(result);
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("signUp")]
        public async Task<IActionResult> SignUp(RegisterRequest registerRequest)
        {
            var result = await _mediator.Send(new RegisterCommand
            {
                UserName = registerRequest.UserName,
                Password = registerRequest.Password,
                PasswordConfirm = registerRequest.PasswordConfirm,
                Country = registerRequest.Country,
                City = registerRequest.City,
                Index = registerRequest.Index
            });
            
            return Ok(result);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh(TokenResponse tokenResponse)
        {
            if (tokenResponse == null)
            {
                return BadRequest("Failed request from client");
            }
            var accessToken = tokenResponse.AccessToken;
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var userName = principal.Identity.Name;
            var user = await _userManager.FindByIdAsync(UserId);

            var newAccessToken = await _tokenService.GenerateAccessTokenAsync(user);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;
            await _userManager.UpdateAsync(user);
            return Ok(new TokenResponse()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }

    }
}
