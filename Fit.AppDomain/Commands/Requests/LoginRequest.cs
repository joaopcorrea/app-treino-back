using Fit.AppDomain.Commands.Responses;
using MediatR;

namespace Fit.AppDomain.Commands.Requests
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
