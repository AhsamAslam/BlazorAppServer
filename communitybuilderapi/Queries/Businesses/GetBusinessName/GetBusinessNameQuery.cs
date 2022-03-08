//using AutoMapper;
//using MediatR;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Queries.Businesses.GetBusinessName
//{
//    public class GetBusinessNameQuery : IRequest<List<BusinessNameDto>>
//    {
//    }
//    public class GetBusinessNameQueryHandler : IRequestHandler<GetBusinessNameQuery, List<BusinessNameDto>>
//    {
//        private readonly IBusinessRepository _businessRepository;
//        private readonly IMapper _mapper;

//        public GetBusinessNameQueryHandler(IBusinessRepository businessRepository, IMapper mapper)
//        {
//            _businessRepository = businessRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<BusinessNameDto>> Handle(GetBusinessNameQuery request, CancellationToken cancellationToken)
//        {
//            var o = await _businessRepository.GetBusinessName();
//            return _mapper.Map<List<BusinessNameModel>, List<BusinessNameDto>>(o.ToList());
//        }
//    }
//}
