//using Dapper;
//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using communitybuilderapi.Dtos;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Repositories
//{
//    public class FanRepository : IFanRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public FanRepository(IConfiguration configuration)
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }

//        public Task<Fan> GetFan(int FanID)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<Fan>> GetFans()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<BusinessFans>> GetBusinessFans()
//        {
//            try
//            {
//                return await db.QueryAsync<BusinessFans>("spGetTopFans",
//                        commandType: CommandType.StoredProcedure);
//            }
//            catch (Exception ex)
//            {

//                throw;
//            }
//        }
//    }
//}
