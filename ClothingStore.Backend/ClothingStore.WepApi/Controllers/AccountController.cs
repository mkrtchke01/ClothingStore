using ClothingStore.Application.Mediator.Account.Commands.Login;
using ClothingStore.Application.Mediator.Account.Commands.Register;
using ClothingStore.Application.Requests;
using ClothingStore.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ClothingStoreControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("SignIn")]
        public async Task<IActionResult> SignIn(LoginRequest loginRequest)
        {
            var token = await _mediator.Send(new LoginCommand
            {
                UserName = loginRequest.UserName,
                Password = loginRequest.Password
            });
            return Ok(token);
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp(RegisterRequest registerRequest)
        {
            var token = await _mediator.Send(new RegisterCommand
            {
                UserName = registerRequest.UserName,
                Password = registerRequest.Password,
                PasswordConfirm = registerRequest.PasswordConfirm,
                Country = registerRequest.Country,
                City = registerRequest.City,
                Index = registerRequest.Index
            });
            
            return Ok(token);
        }

    }
}
