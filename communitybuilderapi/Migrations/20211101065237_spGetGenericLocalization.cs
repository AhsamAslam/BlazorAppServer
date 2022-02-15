using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetGenericLocalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "create OR ALTER PROCEDURE[dbo].[spGetGenericLocalization] " +
              "@LanguageId int " +
              "AS BEGIN" +
              " Begin Try" +
              " select* from GenericLocalizationKeyValues where LanguageId = @LanguageId" +
              " End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
