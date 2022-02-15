using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Interfaces
{
    public interface IFileRepository
    {
        Task<File> UploadFile(File File);
    }
}
