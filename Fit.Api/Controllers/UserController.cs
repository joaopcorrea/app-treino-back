using Fit.AppDomain.Commands.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fit.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : BaseController
    {
        public UserController([FromServices] IMediator mediator) : base(mediator) { }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var response = await _mediator.Send(request);

            return FormatarRetorno(response);
        }

        //[HttpPost("register")]
        //public async Task<IActionResult> Register()
        //{

        //}
    }
}
