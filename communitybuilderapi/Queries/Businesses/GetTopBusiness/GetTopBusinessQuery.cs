//using AutoMapper;
//using MediatR;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Queries.Businesses.GetTopBusiness
//{
//    public class GetTopBusinessQuery: IRequest<List<BusinessDto>>
//    {

//    }
//    public class GetTopBusinessQueryHandler : IRequestHandler<GetTopBusinessQuery, List<BusinessDto>>
//    {
//        private readonly IBusinessRepository _businessRepository;
//        private readonly IMapper _mapper;

//        public GetTopBusinessQueryHandler(IBusinessRepository businessRepository, IMapper mapper)
//        {
//            _businessRepository = businessRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<BusinessDto>> Handle(GetTopBusinessQuery request, CancellationToken cancellationToken)
//        {
//            var o = await _businessRepository.GetTopBusinesses();
//            return _mapper.Map<List<Models.Business>, List<BusinessDto>>(o.ToList());
//        }
//    }

//}
