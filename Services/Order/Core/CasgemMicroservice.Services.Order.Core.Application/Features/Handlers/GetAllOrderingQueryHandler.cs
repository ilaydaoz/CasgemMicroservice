using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using CasgemMicroservice.Services.Order.Core.Application.Features.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Handlers
{
    public class GetAllOrderingQueryHandler : IRequestHandler<GetAllOrderingQueryRequest, List<ResultOrderingDto>>
    {
        private IRepository<Ordering> _repository;
        private IMapper _mapper;

        public GetAllOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOrderingDto>> Handle(GetAllOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultOrderingDto>>(values);
        }
    }
}
