using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<CreateOrderDto,Domain.Entities.Order>().ReverseMap();
            CreateMap<ResultOrderDto, Domain.Entities.Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Domain.Entities.Order>().ReverseMap();
        }
    }
}
