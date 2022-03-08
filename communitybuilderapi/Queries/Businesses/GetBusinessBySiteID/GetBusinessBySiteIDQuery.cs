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

//namespace communitybuilderapi.Queries.Businesses.GetBusinessBySiteID
//{
//    public class GetBusinessBySiteIDQuery : IRequest<List<LocalBusinessCardDto>>
//    {
//        public int SiteID { get; set; }
//        public string SearchText { get; set; }
//    }
//    public class GetBusinessBySiteIDQueryHandler : IRequestHandler<GetBusinessBySiteIDQuery, List<LocalBusinessCardDto>>
//    {
//        private readonly IBusinessRepository _businessRepository;
//        private readonly IMapper _mapper;

//        public GetBusinessBySiteIDQueryHandler(IBusinessRepository businessRepository, IMapper mapper)
//        {
//            _businessRepository = businessRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<LocalBusinessCardDto>> Handle(GetBusinessBySiteIDQuery request, CancellationToken cancellationToken)
//        {
//            var BusinessListBySiteID = await _businessRepository.GetBusinessBySiteID(request.SiteID, request.SearchText);
//            return _mapper.Map<List<LocalBusinessCard>, List<LocalBusinessCardDto>>(BusinessListBySiteID.ToList());
//        }
//    }
//}
