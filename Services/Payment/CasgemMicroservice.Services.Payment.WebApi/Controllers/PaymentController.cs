using CasgemMicroservice.Services.Payment.WebApi.Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Payment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PaymetContext _context;

        public PaymentController(PaymetContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult PaymentList()
        {
            var values = _context.PaymetDetails.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult PaymentCreate(PaymetDetail paymetDetail)
        {
            _context.PaymetDetails.Add(paymetDetail);
            return Ok();
        }
    }
}
