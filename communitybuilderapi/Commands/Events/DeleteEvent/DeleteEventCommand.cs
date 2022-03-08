//using AutoMapper;
//using communitybuilderapi.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Commands.Events.DeleteEvent
//{
//    public class DeleteEventCommand: IRequest<int>
//    {
//        public int EventID { get; set; }
//    }

//    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, int>
//    {
//        private readonly IEventRepository _eventRepository;
//        private readonly IMapper _mapper;

//        public DeleteEventCommandHandler(IEventRepository eventRepository, IMapper mapper)
//        {
//            _eventRepository = eventRepository;
//            _mapper = mapper;
//        }
//        public async Task<int> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
//        {
//            try
//            {
//                return await _eventRepository.DeleteEvent(request.EventID);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
            
//        }
//    }
//}
