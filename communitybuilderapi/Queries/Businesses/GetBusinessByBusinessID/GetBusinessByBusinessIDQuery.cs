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

//namespace communitybuilderapi.Queries.Businesses.GetBusinessByBusinessID
//{
//    public class GetBusinessByBusinessIDQuery:IRequest<List<BusinessDetailDto>>
//    {
//        public int BusinessID { get; set; }
//    }
//    public class GetBusinessByBusinessIDQueryHandler : IRequestHandler<GetBusinessByBusinessIDQuery, List<BusinessDetailDto>>
//    {
//        private readonly IBusinessRepository _businessRepository;
//        private readonly IMapper _mapper;

//        public GetBusinessByBusinessIDQueryHandler(IBusinessRepository businessRepository, IMapper mapper)
//        {
//            _businessRepository = businessRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<BusinessDetailDto>> Handle(GetBusinessByBusinessIDQuery request, CancellationToken cancellationToken)
//        {
//            var BusinessListByBusinessID = await _businessRepository.GetBusinessByBusinessID(request.BusinessID);
//            return _mapper.Map<List<BusinessDetail>, List<BusinessDetailDto>>(BusinessListByBusinessID.ToList());
//        }
//    }
//}
