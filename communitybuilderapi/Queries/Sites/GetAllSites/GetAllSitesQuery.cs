//using AutoMapper;
//using MediatR;
//using communitybuilderapi.Models;
//using communitybuilderapi.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using communitybuilderapi.Dtos;

//namespace communitybuilderapi.Queries.Sites.GetAllSites
//{
//    public class GetAllSitesQuery: IRequest<List<SiteDto>>
//    {

//    }
//    public class GetAllSitesQueryHandler : IRequestHandler<GetAllSitesQuery, List<SiteDto>>
//    {
//        private readonly ISiteRepository _siteRepository;
//        private readonly IMapper _mapper;

//        public GetAllSitesQueryHandler(ISiteRepository siteRepository, IMapper mapper)
//        {
//            _siteRepository = siteRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<SiteDto>> Handle(GetAllSitesQuery request, CancellationToken cancellationToken)
//        {

//            var o = await _siteRepository.GetAllSites();
//            return _mapper.Map<List<Site>, List<SiteDto>>(o.ToList());
//        }
//    }
//}
