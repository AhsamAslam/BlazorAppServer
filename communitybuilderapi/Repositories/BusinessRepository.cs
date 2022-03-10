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
using communitybuilderapi.Dtos.BusinessDtos;
using communitybuilderapi.DataModel;

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
        public async Task<AddBusinessDto> AddBusiness(AddBusinessDto Business)
        {
            try
            {
                var sql = "Insert into Event(VirtualOrPhysical, VirtualType, Date, Time, TimeZone,Location, Type, Hyperlink1, Hyperlink2, Comment, DateAdded, " +
                    "AddedByUserID, Inactive, DeactivateOn, DeactivatedByUserID) values(@VirtualOrPhysical, @VirtualType, @Date, @Time, @TimeZone, @Location, @Type, @Hyperlink1," +
                    " @Hyperlink2, @Comment, @DateAdded, @AddedByUserID, @Inactive, @DeactivateOn, @DeactivatedByUserID); "
                          + "Select CAST(SCOPE_IDENTITY() as int);";
                await db.ExecuteAsync(sql, Business).ConfigureAwait(false);
                return Business;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public Task<int> DeleteBusiness(int BusinessID)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<Business> GetBusiness(int BusinessID)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<BusinessDetail>> GetBusinessByBusinessID(int BusinessID)
        //{
        //    try
        //    {

        //        return await db.QueryAsync<BusinessDetail>("spGetBusinessByBusinessID",
        //               this.SetBusinessIDParameter(BusinessID),
        //               commandType: CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

        //public async Task<IEnumerable<LocalBusinessCard>> GetBusinessBySiteID(int SiteID, string SearchText)
        //{
        //    try
        //    {

        //        return await db.QueryAsync<LocalBusinessCard>("spGetBusinessBySiteID",
        //               this.SetParameter(SiteID, SearchText),
        //               commandType: CommandType.StoredProcedure);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

        //public async Task<IEnumerable<Business>> GetBusinesses()
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IEnumerable<Business>> GetTopBusinesses()
        //{
        //    try
        //    {
        //        var sql = "select top 5 * from Business with (nolock) where isnull(Inactive, 0) = 0 ";
        //        return await db.QueryAsync<Business>(sql).ConfigureAwait(false);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        public async Task<IEnumerable<business>> GetBusinessesGrid()
        {
            try
            {
                var Sql = @"Select b.id_business, b.name, a.address1, a.telephone1, 
                            a.email, b.internal_comments from business b with (nolock) 
                            inner join business_address ba with (nolock) on b.id_business = ba.id_business 
                            inner join [address] a with (nolock) on ba.id_address = a.id_address
                            where isnull(b.invisible,0) = 0";
                return await db.QueryAsync<business, address, business_address, business>(Sql
                     , (b, a, ba) => {
                         ba.address = a;
                         ba.business = b;
                         return b;
                     }
                     //splitOn: "id_business,id_address"
                    ).ConfigureAwait(false);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //public async Task<IEnumerable<BusinessNameModel>> GetBusinessName()
        //{
        //    try
        //    {
        //        var sql = "select BusinessID, BusinessName, BusinessAddressCity  from Business with (nolock)";
        //        return await db.QueryAsync<BusinessNameModel>(sql).ConfigureAwait(false);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //public Task<Business> UpdateBusiness(Business Business)
        //{
        //    throw new NotImplementedException();
        //}

        //private DynamicParameters SetParameter(int siteId, string SearchText)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@SiteID", siteId);
        //    param.Add("@SearchText", SearchText);
        //    return param;
        //}
        //private DynamicParameters SetBusinessIDParameter(int BusinessID)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@BusinessID", BusinessID);
        //    return param;
        //}


    }
}
