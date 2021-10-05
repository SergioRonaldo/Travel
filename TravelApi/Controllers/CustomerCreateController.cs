using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CustomerCreate")]
        [Authorize]
        public async Task<IActionResult> CustomerCreate([FromBody] CreateCustomerCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
