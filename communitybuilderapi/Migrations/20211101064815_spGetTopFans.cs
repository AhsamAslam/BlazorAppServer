using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetTopFans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "create OR ALTER PROCEDURE [dbo].[spGetTopFans] " +
              "AS BEGIN " +
              "select top 10 b.BusinessName,COUNT(fa.UserID) NumberOfFans, " +
              "(select Count(fa.UserID) from Fan fa where fa.Date BETWEEN DATEADD(DAY, -7, GETDATE()) " +
              "AND DATEADD(DAY, 1, GETDATE()) and fa.BusinessID = b.BusinessID) as ThisWeek " +
              "from Fan fa inner join Business b on b.BusinessID = fa.BusinessID " +
              "and isnull(b.Inactive, 0) = 0 group by b.BusinessID,b.BusinessName " +
              "order by NumberOfFans desc END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
