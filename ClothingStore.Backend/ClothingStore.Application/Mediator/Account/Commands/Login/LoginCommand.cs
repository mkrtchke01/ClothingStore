using ClothingStore.Application.Responses;
using MediatR;

namespace ClothingStore.Application.Mediator.Account.Commands.Login
{
    public class LoginCommand : IRequest<TokenResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
