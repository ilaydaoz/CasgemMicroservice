using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Features.Handlers;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Order.Presenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var value = await _mediator.Send(new GetAllAddressQueryRequest());
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AddressGetById(int id)
        {
            var values = await _mediator.Send(new GetByIdAddressQueryRequest(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> AddressCreata(CreateAddressCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("adress eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> AddresUpdate(UpdateAddressCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("adres güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> AddresDelete(int id)
        {
            await _mediator.Send(new RemoveAddressCommadRequest(id));
            return Ok("adres silindi");
        }
    }
}