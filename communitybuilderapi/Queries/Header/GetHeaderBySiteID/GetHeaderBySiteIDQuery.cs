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

//namespace communitybuilderapi.Queries.Header.GetHeaderBySiteID
//{
//    public class GetHeaderBySiteIDQuery : IRequest<SiteHeaders>
//    {
//        public int SiteID { get; set; }
//        public string SitePage { get; set; }
//    }
//    public class GetHeaderBySiteIDQueryHandler : IRequestHandler<GetHeaderBySiteIDQuery, SiteHeaders>
//    {
//        private readonly IHeaderRepository _headerRepository;
//        private readonly IMapper _mapper;

//        public GetHeaderBySiteIDQueryHandler(IHeaderRepository headerRepository, IMapper mapper)
//        {
//            _headerRepository = headerRepository;
//            _mapper = mapper;
//        }

//        public async Task<SiteHeaders> Handle(GetHeaderBySiteIDQuery request, CancellationToken cancellationToken)
//        {

//            var o = await _headerRepository.GetHeadersBySiteIDAndSitePage(request.SiteID, request.SitePage);
//            return _mapper.Map<SiteHeader, SiteHeaders>(o);
//        }
//    }
//}
