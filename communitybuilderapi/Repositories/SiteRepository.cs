using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using communitybuilderapi.Models;
using communitybuilderapi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Repositories
{
    public class SiteRepository : ISiteRepository
    {

        #region
        private IDbConnection db;
        #endregion
        public SiteRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
        }

        public async Task<IEnumerable<Site>> GetAllSites()
        {
            try
            {
                return await db.QueryAsync<Site>("spGetSites",
                        commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Site> GetSiteBySiteURL(string SiteURL)
        {
            var sql = "select * from [Site] where [URL] = @SiteURL";
            return await db.QueryFirstAsync<Site>(sql, new { SiteURL = SiteURL }).ConfigureAwait(false);

        }

        public async Task<int> GetSiteIDByURL(string URL)
        {
            try
            {
                var sql = "select SiteID from Site where URL = @URL";
                return await db.ExecuteScalarAsync<int>(sql, new { URL = URL }).ConfigureAwait(false);
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
