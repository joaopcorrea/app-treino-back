using Fit.AppDomain.Commands.Requests;
using Fit.AppDomain.Commands.Responses;
using Fit.AppDomain.Interfaces;
using MediatR;

namespace Fit.AppDomain.Handlers
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IUserService _userService;
        public LoginHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var loggedIn = await _userService.Login(request.Email, request.Password);

            var response = new LoginResponse
            {
                LoggedIn = loggedIn
            };

            return response;
        }
    }
}
