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

//namespace communitybuilderapi.Queries.Localization.GetGenericLocalization
//{
//    public class GetGenericLocalizationQuery : IRequest<List<GenericLocalizationKeyValuesDto>>
//    {
//        public int LanguageId { get; set; }
//    }
//    public class GetGenericLocalizationQueryHandler : IRequestHandler<GetGenericLocalizationQuery, List<GenericLocalizationKeyValuesDto>>
//    {
//        private readonly IGenericLocalizationRepository _genericLocalizationRepository;
//        private readonly IMapper _mapper;

//        public GetGenericLocalizationQueryHandler(IGenericLocalizationRepository genericLocalizationRepository, IMapper mapper)
//        {
//            _genericLocalizationRepository = genericLocalizationRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<GenericLocalizationKeyValuesDto>> Handle(GetGenericLocalizationQuery request, CancellationToken cancellationToken)
//        {

//            var GenericLocalization = await _genericLocalizationRepository.GetLocalizationGenericKeyValues(request.LanguageId);
//            return _mapper.Map<List<GenericLocalizationKeyValues>, List<GenericLocalizationKeyValuesDto>>(GenericLocalization.ToList());

//        }

//    }
//}
