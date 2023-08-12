using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetByIdAddressQueryRequest : IRequest<ResultAdressDto>
    {
        public int Id { get; set; }
        public GetByIdAddressQueryRequest(int id)
        {
            Id = id;
        }
    }
}
