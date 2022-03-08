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

//namespace communitybuilderapi.Queries.Events.GetEvent
//{
//    public class GetEventQuery : IRequest<List<EventDto>>
//    {
//    }
//    public class GetEventQueryHandler : IRequestHandler<GetEventQuery,List<EventDto>>
//    {
//        private readonly IEventRepository _eventRepository;
//        private readonly IMapper _mapper;

//        public GetEventQueryHandler(IEventRepository eventRepository, IMapper mapper)
//        {
//            _eventRepository = eventRepository;
//            _mapper = mapper;
//        }

//        public async Task<List<EventDto>> Handle(GetEventQuery request, CancellationToken cancellationToken)
//        {

//            var o = await _eventRepository.GetEvents();
//            return _mapper.Map<List<Event>, List<EventDto>>(o.ToList());
//        }
//    }
//}
