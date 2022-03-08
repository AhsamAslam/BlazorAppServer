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

//namespace communitybuilderapi.Queries.Sites.GetSiteBySiteURL
//{
//    public class GetSiteBySiteURLQuery : IRequest<SiteDto>
//    {
//        public string SiteURL { get; set; }
//    }
//    public class GetSiteBySiteURLQueryHandler : IRequestHandler<GetSiteBySiteURLQuery, SiteDto>
//    {
//        private readonly ISiteRepository _siteRepository;
//        private readonly IMapper _mapper;

//        public GetSiteBySiteURLQueryHandler(ISiteRepository siteRepository, IMapper mapper)
//        {
//            _siteRepository = siteRepository;
//            _mapper = mapper;
//        }

//        public async Task<SiteDto> Handle(GetSiteBySiteURLQuery request, CancellationToken cancellationToken)
//        {

//            var o = await _siteRepository.GetSiteBySiteURL(request.SiteURL);
//            return _mapper.Map<Site, SiteDto>(o);
//        }
//    }
//}
