using AutoMapper;
using MediatR;
using communitybuilderapi.Dtos;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace communitybuilderapi.Queries.Businesses.GetBusinessGrid
{
    public class GetBusinessGridQuery : IRequest<List<BusinessGridDto>>
    {
    }
    public class GetBusinessGridQueryHandler : IRequestHandler<GetBusinessGridQuery, List<BusinessGridDto>>
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;

        public GetBusinessGridQueryHandler(IBusinessRepository businessRepository, IMapper mapper)
        {
            _businessRepository = businessRepository;
            _mapper = mapper;
        }

        public async Task<List<BusinessGridDto>> Handle(GetBusinessGridQuery request, CancellationToken cancellationToken)
        {
            var o = await _businessRepository.GetBusinessesGrid();
            return _mapper.Map<List<BusinessGrid>, List<BusinessGridDto>>(o.ToList());
        }
    }
}
