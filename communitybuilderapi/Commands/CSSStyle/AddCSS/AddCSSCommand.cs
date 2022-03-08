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

//namespace communitybuilderapi.Commands.CSS.AddCSS
//{
//    public class AddCSSCommand : IRequest<CustomCssDto>
//    {
//        public CustomCssDto CSSParam { get; set; }
//    }
//    public class AddCSSCommandHandeler : IRequestHandler<AddCSSCommand, CustomCssDto>
//    {
//        private readonly ICSSRepository _CSSRepository;
//        private readonly IMapper _mapper;
//        public AddCSSCommandHandeler(ICSSRepository CSSRepository,
//            IMapper mapper)
//        {
//            _CSSRepository = CSSRepository;
//            _mapper = mapper;
//        }
//        public async Task<CustomCssDto> Handle(AddCSSCommand request, CancellationToken cancellationToken)
//        {
//            try
//            {
//                var e = _mapper.Map<CustomCssDto, CustomCss>(request.CSSParam);
//                var css = await _CSSRepository.AddCSS(e);
//                request.CSSParam.CustomCssID = css.CustomCssID;
//                return request.CSSParam;

//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}
