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

namespace communitybuilderapi.Queries.Events.GetEventById
{
    public class GetEventByIdQuery: IRequest<EventDto>
    {
        public EventDto EventParam { get; set; }
    }
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, EventDto>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public GetEventByIdQueryHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<EventDto> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var e = _mapper.Map<EventDto, Event>(request.EventParam);
            var Event = await _eventRepository.GetEvent(e.EventID);
            return request.EventParam;

        }
    }

}
