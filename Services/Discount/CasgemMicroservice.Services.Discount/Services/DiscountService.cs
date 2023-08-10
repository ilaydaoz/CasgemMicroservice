using CasgemMicroservice.Services.Discount.Dtos;
using CasgemMicroservice.Services.Discount.Models;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        public Task<Response<NoContent>> CreateDiscountCouponsAsync(CreateDiscountDto createDiscountDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteDiscountCouponsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultDiscountDto>>> GetAllDiscountCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultDiscountDto>> GetByIdDiscountCouponsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateDiscountCouponsAsync(UpdateDiscountDto updateDiscountDto)
        {
            throw new NotImplementedException();
        }
    }
}
