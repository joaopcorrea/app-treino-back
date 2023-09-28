using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fit.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class BaseController : Controller
    {
        public readonly IMediator _mediator;

        public BaseController([FromServices] IMediator mediator)
        {
            _mediator = mediator;
        }

        public ObjectResult FormatarRetorno(object response)
        {
            return StatusCode(200, response);
        }
    }
}
