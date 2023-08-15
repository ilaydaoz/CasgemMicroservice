using CasgemMicroservice.Services.Cargo.BussinessLayer.Abstarct;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;

namespace CasgemMicroservice.Services.Cargo.BussinessLayer.Concrete
{
    public class CargoStatusManager : ICargoStatusServices
    {
        private readonly ICargoStateDal _cargoStateDal;

        public CargoStatusManager(ICargoStateDal cargoStateDal)
        {
            _cargoStateDal = cargoStateDal;
        }

        public void Delete(CargoState entity)
        {
            _cargoStateDal.Delete(entity);
        }

        public List<CargoState> GetAll()
        {
            return _cargoStateDal.GetAll();
        }

        public CargoState GetById(int id)
        {
            return _cargoStateDal.GetById(id);
        }

        public void Insert(CargoState entity)
        {
            _cargoStateDal.Insert(entity);
        }

        public void Update(CargoState entity)
        {
            _cargoStateDal.Update(entity);
        }
    }
}