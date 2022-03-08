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

//namespace communitybuilderapi.Queries.Localization.GetLocalizationBySiteURL
//{
//    public class GetLocalizationBySiteURLQuery : IRequest<List<LanguageLocalizationDto>>
//    {
//        public int SiteID { get; set; }
//    }
//    public class GetLocalizationBySiteURLQueryHandler : IRequestHandler<GetLocalizationBySiteURLQuery, List<LanguageLocalizationDto>>
//    {
//        private readonly ILocalizationRepository _localizationRepository;
//        private readonly IMapper _mapper;

//        public GetLocalizationBySiteURLQueryHandler(ILocalizationRepository localizationRepository, IMapper mapper)
//        {
//            _localizationRepository = localizationRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<LanguageLocalizationDto>> Handle(GetLocalizationBySiteURLQuery request, CancellationToken cancellationToken)
//        {

//            var Localization = await _localizationRepository.GetLocalization(request.SiteID);
//            return _mapper.Map<List<LanguageLocalization>, List<LanguageLocalizationDto>>(Localization.ToList());

//        }

//    }
//}
