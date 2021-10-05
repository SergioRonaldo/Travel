using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateBalanceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UpdateBalanceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("UpdateBalance")]
        [Authorize]
        public async Task<IActionResult> UpdateBalance([FromBody] UpdateBalanceCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
