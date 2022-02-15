using AutoMapper;
using MediatR;
using communitybuilderapi.Models;
using communitybuilderapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using communitybuilderapi.Dtos;

namespace communitybuilderapi.Queries.Localization.GetLanguagesBySiteID
{
    public class GetLanguagesBySiteIDQuery : IRequest<List<LanguageDto>>
    {
        public int SiteID { get; set; }
    }
    public class GetLanguagesBySiteIDQueryHandler : IRequestHandler<GetLanguagesBySiteIDQuery, List<LanguageDto>>
    {
        private readonly ILocalizationRepository _localizationRepository;
        private readonly IMapper _mapper;

        public GetLanguagesBySiteIDQueryHandler(ILocalizationRepository localizationRepository, IMapper mapper)
        {
            _localizationRepository = localizationRepository;
            _mapper = mapper;
        }

        public async Task<List<LanguageDto>> Handle(GetLanguagesBySiteIDQuery request, CancellationToken cancellationToken)
        {
           
            var Languages = await _localizationRepository.GetLanguages(request.SiteID);
            var l = Languages.ToList();
            return _mapper.Map<List<Languages>, List<LanguageDto>>(l);

        }

    }
}
