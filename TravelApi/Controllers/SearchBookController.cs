using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchBookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SearchBookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("SearchBook")]
        [Authorize]
        public async Task<IActionResult> SearchBook(int ISBN)
        {
            var model = new SearchBookQuery()
            {
                ISBN = ISBN
            };
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }
    }
}
