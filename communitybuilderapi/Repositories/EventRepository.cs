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
//    public class EventRepository : IEventRepository
//    {
//        #region
//        private IDbConnection db;
//        #endregion
//        public EventRepository(IConfiguration configuration )
//        {
//            this.db = new SqlConnection(configuration.GetConnectionString("CommunityBuilder"));
//        }
//        public async Task<Event> AddEvent(Event Event)
//        {
//            try
//            {
//                var sql = "Insert into Event(VirtualOrPhysical, VirtualType, Date, Time, TimeZone,Location, Type, Hyperlink1, Hyperlink2, Comment, DateAdded, " +
//                    "AddedByUserID, Inactive, DeactivateOn, DeactivatedByUserID) values(@VirtualOrPhysical, @VirtualType, @Date, @Time, @TimeZone, @Location, @Type, @Hyperlink1," +
//                    " @Hyperlink2, @Comment, @DateAdded, @AddedByUserID, @Inactive, @DeactivateOn, @DeactivatedByUserID); "
//                          + "Select CAST(SCOPE_IDENTITY() as int);";
//                await db.ExecuteAsync(sql, Event).ConfigureAwait(false);
//                return Event;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        public async Task<int> DeleteEvent(int EventID)
//        {
//            try
//            {
//                var sql = "update Event set Inactive = 1 where EventID = @EventID";
//                return await db.ExecuteAsync(sql, new { EventID  = EventID}).ConfigureAwait(false);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }
//        public async Task<Event> GetEvent(int EventID)
//        {
//            try
//            {
//                var sql = "Select * from Event where EventID = @EventID and isnull(Inactive,0) = 0";
//                return await db.QueryFirstOrDefaultAsync<Event>(sql, new { @EventID = EventID }).ConfigureAwait(false);
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public async Task<IEnumerable<Event>> GetEvents()
//        {
//            try
//            {
//                var sql = "select * from Event where isnull(Inactive,0) = 0";
//                return await db.QueryAsync<Event>(sql).ConfigureAwait(false);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }
//        public async Task<IEnumerable<Event>> GetTopEvents()
//        {
//            try
//            {
//                var sql = "select top 5 * from Event where isnull(Inactive,0) = 0";
//                return await db.QueryAsync<Event>(sql).ConfigureAwait(false);
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        public async Task<Event> UpdateEvent(Event Event)
//        {
//            try
//            {
//                var sql = "Update Event Set VirtualOrPhysical = @VirtualOrPhysical, VirtualType = @VirtualType, Date = @Date, Time = @Time, " +
//                    "TimeZone = @TimeZone, Location = @Location, Type = @Type, Hyperlink1 = @Hyperlink1, Hyperlink2 = @Hyperlink2, " +
//                    "Comment = @Comment, DateAdded = @DateAdded, AddedByUserID = @AddedByUserID, Inactive = @Inactive, DeactivateOn = @DeactivateOn," +
//                    " DeactivatedByUserID = @DeactivatedByUserID where EventID = @EventID";
//                await db.ExecuteAsync(sql, Event).ConfigureAwait(false);
//                return Event;
//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        public void Dispose(bool disposing)
//        {
//            // Dispose of unmanaged resources.
//            Dispose(true);
//            // Suppress finalization.
//            GC.SuppressFinalize(this);
//        }

       
//    }
//}
