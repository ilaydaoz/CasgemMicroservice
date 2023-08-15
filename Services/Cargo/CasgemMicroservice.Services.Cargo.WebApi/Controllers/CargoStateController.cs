using CasgemMicroservice.Services.Cargo.BussinessLayer.Abstarct;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoStateController : ControllerBase
    {

        private readonly ICargoStatusServices _cargoDetailService;

        public CargoStateController(ICargoStatusServices cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public IActionResult CargoStateList()
        {
            var values = _cargoDetailService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult CargoStateGet(int id)
        {
            var values = _cargoDetailService.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CargoStateCreate(CargoState cargoDetail)
        {
            _cargoDetailService.Insert(cargoDetail);
            return Ok("Kargo Detayı eklendi");
        }
        [HttpPut]
        public IActionResult CargoStateUpdate(CargoState cargoDetail)
        {
            _cargoDetailService.Update(cargoDetail);
            return Ok("Kargo Detayı güncellendi");
        }
        [HttpDelete]
        public IActionResult CargoStateDelete(CargoState cargoDetail)
        {
            _cargoDetailService.Delete(cargoDetail);
            return Ok("Kargo Detayı Silindi");
        }
    }
}
