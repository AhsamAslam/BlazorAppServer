using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetAllBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetAllBusiness] AS BEGIN Begin Try select b.*, bf.FileURL from Business b inner join BusinessFile bf on b.BusinessID = bf.BusinessID where bf.SortIndex = 1 End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
