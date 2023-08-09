using CasgemMicroservice.Basket.Dto;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userID);
        Task<Response<bool>> SaveOrUpdate(BasketDto dto);
        Task<Response<bool>> DeleteBasket(string userID);
    }
}
