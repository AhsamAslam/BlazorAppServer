using communitybuilderapi.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Interfaces
{
    public interface IVideoRepository
    {
        Task<int> SaveVideo(video video);
    }
}
