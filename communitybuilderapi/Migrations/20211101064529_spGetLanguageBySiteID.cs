using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetLanguageBySiteID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetLanguageBySiteID] " +
              "@SiteID int " +
              "AS BEGIN " +
              "Begin Try " +
              "select la.*, s.DefaultLanguageID from[Language] la with(nolock) " +
              "inner join Localization lo  with(nolock) on la.LanguageID = lo.LanguageID  " +
              "inner join Site s with(nolock) on s.SiteID = lo.SiteID where lo.SiteID = @SiteID " +
              "End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
