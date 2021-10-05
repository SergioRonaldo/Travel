using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CreateUser")]
        //[Authorize]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
