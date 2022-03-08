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
//    public class FileRepository : IFileRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public FileRepository(IConfiguration configuration)
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }
//        public async Task<File> UploadFile(File File)
//        {
          
//            try
//            {
//                var sql = "Insert into [File](FileID, FileOriginalName, FileExtension, FileType, FilePath, FileSize) " +
//                    "values(NEWID(), @FileOriginalName, @FileExtension, @FileType, @FilePath, @FileSize)";
//                await db.ExecuteAsync(sql, File).ConfigureAwait(false);
//                return File;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }
//    }
//}
