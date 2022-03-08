//using AutoMapper;
//using MediatR;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Queries.Fans.GetTopFan
//{
//    public class GetTopFanQuery: IRequest<IEnumerable<BusinessFans>>
//    {
//    }
//    public class GetTopFanQueryHandler : IRequestHandler<GetTopFanQuery, IEnumerable<BusinessFans>>
//    {
//        private readonly IFanRepository _fanRepository;
//        private readonly IMapper _mapper;

//        public GetTopFanQueryHandler(IFanRepository fanRepository, IMapper mapper)
//        {
//            _fanRepository = fanRepository;
//            _mapper = mapper;
//        }

//        public async Task<IEnumerable<BusinessFans>> Handle(GetTopFanQuery request, CancellationToken cancellationToken)
//        {
//            var o = await _fanRepository.GetBusinessFans();
//            return o.ToList();
//        }
//    }
//}
