using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using communitybuilderapi.Interfaces;
using communitybuilderapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Repositories
{
    public class BusinessRepository : IBusinessRepository
    {
        #region
        private IDbConnection db;
        #endregion
        public BusinessRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
        }
        public Task<Business> AddBusiness(Business Business)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBusiness(int BusinessID)
        {
            throw new NotImplementedException();
        }

        public async Task<Business> GetBusiness(int BusinessID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BusinessDetail>> GetBusinessByBusinessID(int BusinessID)
        {
            try
            {

                return await db.QueryAsync<BusinessDetail>("spGetBusinessByBusinessID",
                       this.SetBusinessIDParameter(BusinessID),
                       commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<LocalBusinessCard>> GetBusinessBySiteID(int SiteID, string SearchText)
        {
            try
            {

                return await db.QueryAsync<LocalBusinessCard>("spGetBusinessBySiteID",
                       this.SetParameter(SiteID, SearchText),
                       commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Business>> GetBusinesses()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Business>> GetTopBusinesses()
        {
            try
            {
                var sql = "select top 5 * from Business with (nolock) where isnull(Inactive, 0) = 0 ";
                return await db.QueryAsync<Business>(sql).ConfigureAwait(false);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<IEnumerable<BusinessGrid>> GetBusinessesGrid()
        {
            try
            {
                return await db.QueryAsync<BusinessGrid>("spGetAllBusiness",
                       commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<IEnumerable<BusinessNameModel>> GetBusinessName()
        {
            try
            {
                var sql = "select BusinessID, BusinessName, BusinessAddressCity  from Business with (nolock)";
                return await db.QueryAsync<BusinessNameModel>(sql).ConfigureAwait(false);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Task<Business> UpdateBusiness(Business Business)
        {
            throw new NotImplementedException();
        }

        private DynamicParameters SetParameter(int siteId, string SearchText)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiteID", siteId);
            param.Add("@SearchText", SearchText);
            return param;
        }
        private DynamicParameters SetBusinessIDParameter(int BusinessID)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@BusinessID", BusinessID);
            return param;
        }

        
    }
}
