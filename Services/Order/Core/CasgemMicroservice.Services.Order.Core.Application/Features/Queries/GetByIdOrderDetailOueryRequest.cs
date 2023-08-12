using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetByIdOrderDetailOueryRequest : IRequest<ResultOrderDetailDto>
    {
        public int Id { get; set; }
        public GetByIdOrderDetailOueryRequest(int id)
        {
            Id = id;
        }
    }
}
