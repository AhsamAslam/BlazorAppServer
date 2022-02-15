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
    public class HeaderRepository : IHeaderRepository
    {
        #region
        private IDbConnection db;
        #endregion
        public HeaderRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
        }
        public async Task<SiteHeader> GetHeadersBySiteIDAndSitePage(int SiteID, string SitePage)
        {
            return await db.QueryFirstAsync<SiteHeader>("spGetHeaderBySiteIDAndSitePage",
                       this.SetParameter(SiteID, SitePage),
                       commandType: CommandType.StoredProcedure);
        }

        private DynamicParameters SetParameter(int SiteId, string SitePage)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiteID", SiteId);
            param.Add("@SitePage", SitePage);
            return param;
        }
    }
}
