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

//namespace communitybuilderapi.Commands.Files.UplaodFile
//{
//    public class UploadFileCommand : IRequest<FileDto>
//    {
//        public FileDto FileParam { get; set; }
//    }
//    public class UploadFileCommandHandeler : IRequestHandler<UploadFileCommand, FileDto>
//    {
//        private readonly IFileRepository _fileRepository;
//        private readonly IMapper _mapper;
//        public UploadFileCommandHandeler(IFileRepository fileRepository,
//            IMapper mapper)
//        {
//            _fileRepository = fileRepository;
//            _mapper = mapper;
//        }
//        public async Task<FileDto> Handle(UploadFileCommand request, CancellationToken cancellationToken)
//        {
//            try
//            {
//                var file = _mapper.Map<FileDto, File>(request.FileParam);
//                var UploadedFile = await _fileRepository.UploadFile(file);
//                request.FileParam.FileID = UploadedFile.FileID;
//                return request.FileParam;

//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}
