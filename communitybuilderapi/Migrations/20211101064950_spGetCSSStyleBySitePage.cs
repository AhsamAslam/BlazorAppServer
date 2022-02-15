using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetCSSStyleBySitePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetCSSStyleBySitePage] @SitePage nvarchar(50) " +
                "AS BEGIN" +
                " Begin Try " +
                "Declare @SitePageID int = (select SitePageID from SitePage where[Name] = @SitePage) " +
                "Select* from CSS where SitePageID = @SitePageID " +
                "End Try " +
                "Begin Catch " +
                "End Catch " +
                "END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
