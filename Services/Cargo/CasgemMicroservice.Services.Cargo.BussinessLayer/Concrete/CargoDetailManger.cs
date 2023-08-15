using CasgemMicroservice.Services.Cargo.BussinessLayer.Abstarct;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;

namespace CasgemMicroservice.Services.Cargo.BussinessLayer.Concrete
{
    public class CargoDetailManger : ICargoDetailServices
    {
        private readonly ICargoDetailDal _cargoDetailDal;

        public CargoDetailManger(ICargoDetailDal cargoDetailDal)
        {
            _cargoDetailDal = cargoDetailDal;
        }

        public void Delete(CargoDetail entity)
        {
            _cargoDetailDal.Delete(entity);
        }

        public List<CargoDetail> GetAll()
        {
            return _cargoDetailDal.GetAll();
        }

        public CargoDetail GetById(int id)
        {
            return _cargoDetailDal.GetById(id);
        }

        public void Insert(CargoDetail entity)
        {
            _cargoDetailDal.Insert(entity);
        }

        public void Update(CargoDetail entity)
        {
            _cargoDetailDal.Update(entity);
        }
    }
}
