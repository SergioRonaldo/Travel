using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthorCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("AuthorCreate")]
        [Authorize]
        public async Task<IActionResult> AuthorCreate([FromBody] CreateAuthorCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
