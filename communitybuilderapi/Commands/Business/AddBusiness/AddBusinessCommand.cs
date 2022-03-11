using AutoMapper;
using communitybuilderapi.Dtos.BusinessDtos;
using communitybuilderapi.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace communitybuilderapi.Commands.Business.AddBusiness
{
    public class AddBusinessCommand : IRequest<AddBusinessDto>
    {
        public AddBusinessDto BusinessParam { get; set; }
    }

    public class AddBusinessCommandHandeler : IRequestHandler<AddBusinessCommand, AddBusinessDto>
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;
        public AddBusinessCommandHandeler(IBusinessRepository businessRepository,
            IMapper mapper)
        {
            _businessRepository = businessRepository;
            _mapper = mapper;
        }
        public async Task<AddBusinessDto> Handle(AddBusinessCommand request, CancellationToken cancellationToken)
        {
            try
            {
                //var e = _mapper.Map<EventDto, Event>(request.EventParam);
                var Business = await _businessRepository.AddBusiness(request.BusinessParam);
                request.BusinessParam.BusinessId = Business;
                return request.BusinessParam;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
