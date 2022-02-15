using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetLocalizationBySiteID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetLocalizationBySiteID] " +
               "@SiteID int AS " +
               "BEGIN Begin Try " +
               "select lo.*, l.LanguageID, l.SiteID, la.LanguageDescription, la.LanguageCode " +
               "from LocalizationKeyValues lo inner join Localization l on lo.LocalizationID = l.LocalizationID " +
               "inner join[Language] la on la.LanguageID = l.LanguageID and l.SiteID = @SiteID " +
               "End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
