using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetOrderUserByIdQueryHandler : IRequestHandler<GetOrderUserByIdQueryRequst, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderUserByIdQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        async Task<List<ResultOrderingDto>> IRequestHandler<GetOrderUserByIdQueryRequst, List<ResultOrderingDto>>.Handle(GetOrderUserByIdQueryRequst request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetOrderById(x => x.UserID == request.Id);
            return _mapper.Map<List<ResultOrderingDto>>(value);
        }
    }
}
