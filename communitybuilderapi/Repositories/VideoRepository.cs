using communitybuilderapi.DataModel;
using communitybuilderapi.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Repositories
{
    public class VideoRepository: IVideoRepository
    {
        #region
        private IDbConnection db;
        #endregion
        public VideoRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
        }

        public async Task<int> SaveVideo(video video)
        {
            try
            {
                var Sql = @"INSERT INTO video(name,size,type,url UserId) VALUES (@name,@size,@type,@url, @UserId)";
                return await db.ExecuteAsync(Sql, video).ConfigureAwait(false);
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
