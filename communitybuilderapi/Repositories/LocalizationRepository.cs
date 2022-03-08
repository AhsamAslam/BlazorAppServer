//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;
//using Dapper;

//namespace communitybuilderapi.Repositories
//{
//    public class LocalizationRepository : ILocalizationRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public LocalizationRepository(IConfiguration configuration)
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }

//        public async Task<IEnumerable<Languages>> GetLanguages(int SiteID)
//        {
//            try
//            {

//                return await db.QueryAsync<Languages>("spGetLanguageBySiteID",
//                       this.SetParameter(SiteID),
//                       commandType: CommandType.StoredProcedure);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        public async Task<IEnumerable<LanguageLocalization>> GetLocalization(int SiteID)
//        {
//            try
//            {

//                return await db.QueryAsync<LanguageLocalization>("spGetLocalizationBySiteID",
//                       this.SetParameter(SiteID),
//                       commandType: CommandType.StoredProcedure);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }

//        private DynamicParameters SetParameter(int siteId)
//        {
//            DynamicParameters param = new DynamicParameters();
//            param.Add("@SiteID", siteId);
//            return param;
//        }
//    }
//}
