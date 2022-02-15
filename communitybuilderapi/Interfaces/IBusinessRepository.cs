using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Interfaces
{
    public interface IBusinessRepository
    {
        Task<IEnumerable<Business>> GetBusinesses();
        Task<IEnumerable<BusinessNameModel>> GetBusinessName();
        Task<IEnumerable<Business>> GetTopBusinesses();
        Task<Business> GetBusiness(int BusinessID);
        Task<IEnumerable<BusinessDetail>> GetBusinessByBusinessID(int BusinessID);
        Task<Business> AddBusiness(Business Business);
        Task<Business> UpdateBusiness(Business Business);
        Task<int> DeleteBusiness(int BusinessID);

        Task<IEnumerable<LocalBusinessCard>> GetBusinessBySiteID(int SiteID , string SearchText);
        Task<IEnumerable<BusinessGrid>> GetBusinessesGrid();
    }
}
