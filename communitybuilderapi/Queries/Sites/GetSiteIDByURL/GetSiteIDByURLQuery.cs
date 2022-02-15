using AutoMapper;
using MediatR;
using communitybuilderapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace communitybuilderapi.Queries.Sites.GetSiteIDByURL
{
    public class GetSiteIDByURLQuery: IRequest<int>
    {
        public string SiteURL { get; set; }
    }
    public class GetSiteIDByURLQueryHandler : IRequestHandler<GetSiteIDByURLQuery, int>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly IMapper _mapper;

        public GetSiteIDByURLQueryHandler(ISiteRepository siteRepository, IMapper mapper)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(GetSiteIDByURLQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _siteRepository.GetSiteIDByURL(request.SiteURL);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
