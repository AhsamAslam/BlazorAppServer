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

namespace communitybuilderapi.Queries.CSS.GetCSS
{
    public class GetCSSQuery : IRequest<List<CustomCssDto>>
    {
        public string SitePage { get; set; }
    }
    public class GetCSSQueryHandler : IRequestHandler<GetCSSQuery, List<CustomCssDto>>
    {
        private readonly ICSSRepository _CSSRepository;
        private readonly IMapper _mapper;

        public GetCSSQueryHandler(ICSSRepository CSSRepository, IMapper mapper)
        {
            _CSSRepository = CSSRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomCssDto>> Handle(GetCSSQuery request, CancellationToken cancellationToken)
        {
            var css = await _CSSRepository.GetCSS(request.SitePage);
            return _mapper.Map<List<CustomCss>, List<CustomCssDto>>(css.ToList());
        }
    }
}
