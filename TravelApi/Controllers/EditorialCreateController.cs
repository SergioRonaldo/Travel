using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EditorialCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EditorialCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("EditorialCreate")]
        [Authorize]
        public async Task<IActionResult> EditorialCreate([FromBody] CreateEditorialCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
