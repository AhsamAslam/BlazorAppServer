using AutoMapper;
using communitybuilderapi.DataModel;
using communitybuilderapi.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace communitybuilderapi.Commands.Video
{
    public class SaveVideoCommand : IRequest<int>
    {
        public video video { get; set; }
    }
    public class SaveVideoCommandHandeler : IRequestHandler<SaveVideoCommand, int>
    {
        private readonly IVideoRepository _videoRepository;
        private readonly IMapper _mapper;
        public SaveVideoCommandHandeler(IVideoRepository videoRepository,
            IMapper mapper)
        {
            _videoRepository = videoRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(SaveVideoCommand request, CancellationToken cancellationToken)
        {
            try
            {
                //var e = _mapper.Map<EventDto, Event>(request.EventParam);
                var video = await _videoRepository.SaveVideo(request.video);
                
                return video;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
