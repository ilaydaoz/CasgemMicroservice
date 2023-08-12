using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetByIdOrderingQueryRequest :IRequest<ResultOrderingDto>
    {  public int Id { get; set; } 
        public GetByIdOrderingQueryRequest(int id)
        {
            Id = id;
        }
    }
}
