using AutoMapper;
using MediatR;
using communitybuilderapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using communitybuilderapi.Models;
using communitybuilderapi.Dtos;

namespace communitybuilderapi.Commands.Events.UpdateEvent
{
    public class UpdateEventCommand: IRequest<EventDto>
    {
        public EventDto EventParam { get; set; }
    }
    public class UpdateEventCommandHandeler : IRequestHandler<UpdateEventCommand, EventDto>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        public UpdateEventCommandHandeler(IEventRepository eventRepository,
            IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<EventDto> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var e = _mapper.Map<EventDto, Event>(request.EventParam);
                var Event = await _eventRepository.UpdateEvent(e);
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
