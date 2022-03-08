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

//namespace communitybuilderapi.Queries.Events.GetTopEvent
//{
//    public class GetTopEventQuery : IRequest<List<EventDto>>
//    {
//    }
//    public class GetTopEventQueryHandler : IRequestHandler<GetTopEventQuery, List<EventDto>>
//    {
//        private readonly IEventRepository _eventRepository;
//        private readonly IMapper _mapper;

//        public GetTopEventQueryHandler(IEventRepository eventRepository, IMapper mapper)
//        {
//            _eventRepository = eventRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<EventDto>> Handle(GetTopEventQuery request, CancellationToken cancellationToken)
//        {
//            var o = await _eventRepository.GetTopEvents();
//            return _mapper.Map<List<Event>, List<EventDto>>(o.ToList());
//        }
//    }
//}
