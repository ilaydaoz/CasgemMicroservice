using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;

namespace CasgemMicroservice.Services.Order.Core.Application.Mapping
{
    public class AdressProfile : Profile
    {
        public AdressProfile() 
        { 
            CreateMap<ResultAdressDto, Address>().ReverseMap();
            CreateMap<CreateAdressDto, Address>().ReverseMap();
            CreateMap<UpdateAdressDto, Address>().ReverseMap();
        }
    }
}
