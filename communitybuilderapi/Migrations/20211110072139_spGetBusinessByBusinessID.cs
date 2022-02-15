using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class spGetBusinessByBusinessID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = "Create OR ALTER PROCEDURE [dbo].[spGetBusinessByBusinessID] @BusinessID int AS BEGIN Begin Try Select distinct b.*, bf.FileURL, bf.IconURL, bf.SortIndex as BusinessFileSortIndex, bf.Title as BusinessFileTitle, bf.Category, bf.Stamp, bc.Title as BusinessCommentTitle, bc.Comment, bc.UserID as CommentUserID, bc.PublishDate as BusinessCommentPublishDate from Business b inner join BusinessFile bf on b.BusinessID = bf.BusinessID inner join BusinessComment bc on b.BusinessID = bc.BusinessID where b.BusinessID = @BusinessID End Try Begin Catch End Catch END";
            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
