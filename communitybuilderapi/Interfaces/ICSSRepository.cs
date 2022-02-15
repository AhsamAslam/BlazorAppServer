using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Interfaces
{
    public interface ICSSRepository
    {
        Task<IEnumerable<CustomCss>> GetCSS(string SitePage);
        Task<CustomCss> AddCSS(CustomCss Css);
    }
}
