using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Context;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Repositries;
using CasgemMicroservice.Services.Cargo.EntityLayer.Entities;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.EntityFramwork
{
    public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
    {
        public EfCargoStateDal(CargoContext cargoContext) : base(cargoContext)
        {
        }
    }
}
