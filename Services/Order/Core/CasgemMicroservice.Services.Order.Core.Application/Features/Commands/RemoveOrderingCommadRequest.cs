using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class RemoveOrderingCommadRequest : IRequest
    {
        public int Id { get; set; }
        public RemoveOrderingCommadRequest(int id)
        {
            Id = id;
        }
    }
}
