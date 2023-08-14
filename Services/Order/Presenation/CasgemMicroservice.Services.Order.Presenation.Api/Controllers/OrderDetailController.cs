using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Order.Presenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var value = await _mediator.Send(new GetAllOrderDetailQueryRequest());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderDetailGetById(int id)
        {
            var values = await _mediator.Send(new GetByIdOrderDetailOueryRequest(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> OrderDetailCreata(CreateOrderDetailCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("order eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> AddresUpdate(UpdateOrderDetailCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("order güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> AddresDelete(int id)
        {
            await _mediator.Send(new RemoveOrderDetailCommandRequest(id));
            return Ok("order Silindi");
        }
    }
}
