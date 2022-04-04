using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class AddBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var Sql = @"Create PROCEDURE AddBusiness
                        (
                         @BusinesName nvarchar(250),
                         @BusinessAddress nvarchar(120),
                         @BusinessTelephone nvarchar(MAX),
                         @BusinessEmail nvarchar(Max),
                         @BusinessComment nvarchar(120)
                        )
                        as
                        Begin
                        
                        Insert into business([guid], [name], internal_comments, latitude, longitude,language_default, created_by_id, created_datetime,
                        make_active_datetime, invisible, inactive) values(NEWID(), @BusinesName, @BusinessComment, 0, 0, 1, 1, GETDATE(), GETDATE(), 0, 1)
                        
                        DECLARE @BusinessId AS int = (SELECT SCOPE_IDENTITY())
                        
                        insert into[address] (address1, telephone1, email, created_by_id, created_datetime, make_active_datetime,
                        invisible, inactive) values(@BusinessAddress, @BusinessTelephone, @BusinessEmail,1,GETDATE(),GETDATE(),0,1)
                        
                        DECLARE @AddressId AS int = (SELECT SCOPE_IDENTITY())
                        
                        insert into business_addresses(id_business, id_address, created_by_id, created_datetime,
                        make_active_datetime, invisible, inactive, is_physical, is_billing, is_administrative)
                        values(@BusinessId, @AddressId, 1, GETDATE(), GETDATE(), 0, 1, 1, 1, 1)
                        end";

            migrationBuilder.Sql(Sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
