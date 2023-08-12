using CasgemMicroservice.Services.Order.Core.Application.Features.Commands;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommandRequest>
    {
        private IRepository<Ordering> _repository;

        public Task Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Ordering
            {
                UserID = request.UserID,
                OrderDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString()),
                TotalPrice = request.TotalPrice,
            };
            return _repository.CreateAsync(values);
        }
    }
}
