using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetBusinessBySiteID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "CREATE OR ALTER PROCEDURE [dbo].[spGetBusinessBySiteID]" +
               " @SiteID int, @SearchText nvarchar(100) = '' " +
               "AS BEGIN Begin Try " +
               "if (@SearchText = '' or @SearchText is null) begin " +
               "select b.BusinessID, b.BusinessName, b.Type, bf.IconURL from Business b " +
               "inner join BusinessFile bf on b.BusinessID = bf.BusinessID " +
               "where b.SiteID = @SiteID and bf.SortIndex = 1 end " +
               "else begin select distinct b.BusinessID, b.BusinessName, b.Type, bf.IconURL " +
               "from Business b inner join BusinessFile bf on b.BusinessID = bf.BusinessID " +
               "where b.SiteID = @SiteID and bf.SortIndex = 1 " +
               "and(b.BusinessName like '%' + @SearchText + '%' or " +
               "b.Type like '%' + @SearchText + '%' or b.BusinessNumber like '%' + @SearchText + '%') " +
               "end End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
