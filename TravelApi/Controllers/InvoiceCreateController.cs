using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceCreateController : ControllerBase
    {
        private readonly IMediator _mediator;
        public InvoiceCreateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("InvoiceCreate")]
        [Authorize]
        public async Task<IActionResult> InvoiceCreate([FromBody] CreateInvoiceCommand model)
        {
            var result = await _mediator.Send(model);
            return Ok(new { result });
        }


    }
}
