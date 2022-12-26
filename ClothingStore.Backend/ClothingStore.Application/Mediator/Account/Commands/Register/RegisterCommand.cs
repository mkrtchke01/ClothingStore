using ClothingStore.Application.Responses;
using MediatR;

namespace ClothingStore.Application.Mediator.Account.Commands.Register
{
    public class RegisterCommand : IRequest<TokenResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Index { get; set; }
    }
}
