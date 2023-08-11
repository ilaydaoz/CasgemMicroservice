using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<ResultOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<CreateOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<UpdateOrderDetailDto, OrderDetail>().ReverseMap();
        }
    }
}
