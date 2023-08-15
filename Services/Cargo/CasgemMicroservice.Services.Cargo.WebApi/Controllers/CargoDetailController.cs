using CasgemMicroservice.Services.Cargo.BussinessLayer.Abstarct;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroservice.Services.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailController : ControllerBase
    {

        private readonly ICargoDetailServices _cargoDetailService;

        public CargoDetailController(ICargoDetailServices cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }

        [HttpGet]
        public IActionResult CargoDetailList()
        {
            var values = _cargoDetailService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]

        public IActionResult CargoDetailGet(int id)
        {
            var values = _cargoDetailService.GetById(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CargoDetailCreate(CargoDetail cargoDetail)
        {
            _cargoDetailService.Insert(cargoDetail);
            return Ok("Kargo Detayı eklendi");
        }
        [HttpPut]
        public IActionResult CargoDetailUpdate(CargoDetail cargoDetail)
        {
            _cargoDetailService.Update(cargoDetail);
            return Ok("Kargo Detayı eklendi");
        }
        [HttpDelete]
        public IActionResult CargoDetailDelete(CargoDetail cargoDetail)
        {
            _cargoDetailService.Delete(cargoDetail);
            return Ok("Kargo Detayı Silindi");
        }
    }
}
