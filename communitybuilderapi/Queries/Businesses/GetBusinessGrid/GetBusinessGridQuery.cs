using AutoMapper;
using MediatR;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using communitybuilderapi.Dtos.BusinessDtos;
using communitybuilderapi.DataModel;

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
            var list =  _mapper.Map<List<business>, List<BusinessGridDto>>(o.ToList());
            return list;
        }
    }
}
