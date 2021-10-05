using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("BookCreate")]
        [Authorize]
        public async Task<IActionResult> BookCreate([FromBody] CreateBookCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
