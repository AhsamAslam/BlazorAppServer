//using Dapper;
//using Microsoft.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using communitybuilderapi.Interfaces;
//using communitybuilderapi.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;

//namespace communitybuilderapi.Repositories
//{
//    public class CSSRepository : ICSSRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public CSSRepository(IConfiguration configuration)
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }

//        public async Task<CustomCss> AddCSS(CustomCss css)
//        {
//            try
//            {
//                var sql = "update CSS set TextColor = @TextColor, [TextSize] = @TextSize where CSSID = 1";
//                await db.ExecuteAsync(sql, css).ConfigureAwait(false);
//                return css;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        public async Task<IEnumerable<CustomCss>> GetCSS(string SitePage)
//        {
//            try
//            {
//                return await db.QueryAsync<CustomCss>("spGetCSSStyleBySitePage",
//                       this.SetParameter(SitePage),
//                       commandType: CommandType.StoredProcedure);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private DynamicParameters SetParameter(string SitePage)
//        {
//            DynamicParameters param = new DynamicParameters();
//            param.Add("@SitePage", SitePage);
//            return param;
//        }
//    }
//}
