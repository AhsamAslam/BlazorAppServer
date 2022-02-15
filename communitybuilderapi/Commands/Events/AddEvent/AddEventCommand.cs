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

namespace communitybuilderapi.Commands.Events.AddEvent
{
    public class AddEventCommand : IRequest<EventDto>
    {
        public EventDto EventParam { get; set; }
    }

    public class AddEventCommandHandeler : IRequestHandler<AddEventCommand, EventDto>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        public AddEventCommandHandeler(IEventRepository eventRepository,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<EventDto> Handle(AddEventCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var e = _mapper.Map<EventDto,Event>(request.EventParam);
                var Event = await _eventRepository.AddEvent(e);
                request.EventParam.EventID = Event.EventID;
                return request.EventParam;
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
