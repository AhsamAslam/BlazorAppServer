//using Dapper;
//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using communitybuilderapi.Models;
//using communitybuilderapi.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Repositories
//{
//    public class GenericLocalizationRepository : IGenericLocalizationRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public GenericLocalizationRepository(IConfiguration configuration)
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }
//        public async Task<IEnumerable<GenericLocalizationKeyValues>> GetLocalizationGenericKeyValues(int LanguageId)
//        {
//            try
//            {
//                return await db.QueryAsync<GenericLocalizationKeyValues>("spGetGenericLocalization", new { LanguageId },
//                       commandType: CommandType.StoredProcedure);

//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }
//    }
//}
