using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDto;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Queries
{
    public class GetAllOrderDetailQueryRequest : IRequest<List<ResultOrderDetailDto>>
    {
    }
}
