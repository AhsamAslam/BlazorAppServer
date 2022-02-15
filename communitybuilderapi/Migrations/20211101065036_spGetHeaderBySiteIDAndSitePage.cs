using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetHeaderBySiteIDAndSitePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetHeaderBySiteIDAndSitePage] " +
                "@SiteID int, @SitePage nvarchar(MAX) " +
                "AS BEGIN " +
                "Begin Try " +
                "Declare @SitePageID int = " +
                "(Select SitePageID from SitePage where Name = @SitePage) " +
                "Select * from SiteHeader where SiteID = @SiteID and " +
                "SitePageID = @SitePageID End " +
                "Try Begin Catch " +
                "End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
