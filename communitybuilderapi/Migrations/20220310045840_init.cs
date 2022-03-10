using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address1 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    address2 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    address3 = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    city = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    state = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    postalcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    country = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    telephone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.id_address);
                });

            migrationBuilder.CreateTable(
                name: "business",
                columns: table => new
                {
                    id_business = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    tagline = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    short_description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    our_story = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<decimal>(type: "decimal(8,6)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    language_default = table.Column<int>(type: "int", nullable: false),
                    search_terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    locally_owned = table.Column<int>(type: "int", nullable: false),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business", x => x.id_business);
                });

            migrationBuilder.CreateTable(
                name: "business_address",
                columns: table => new
                {
                    id_business_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_business = table.Column<int>(type: "int", nullable: false),
                    id_address = table.Column<int>(type: "int", nullable: false),
                    is_physical = table.Column<bool>(type: "bit", nullable: false),
                    is_billing = table.Column<bool>(type: "bit", nullable: false),
                    is_administrative = table.Column<bool>(type: "bit", nullable: false),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_address", x => x.id_business_address);
                });

            migrationBuilder.CreateTable(
                name: "business_person",
                columns: table => new
                {
                    id_business_person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_business = table.Column<int>(type: "int", nullable: false),
                    id_person = table.Column<int>(type: "int", nullable: false),
                    is_owner = table.Column<bool>(type: "bit", nullable: false),
                    is_contact = table.Column<bool>(type: "bit", nullable: false),
                    is_administrative = table.Column<bool>(type: "bit", nullable: false),
                    title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_person", x => x.id_business_person);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id_person = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asp_net_user_Id = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    prefix = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    language_default = table.Column<int>(type: "int", nullable: false),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id_person);
                });

            migrationBuilder.CreateTable(
                name: "person_address",
                columns: table => new
                {
                    id_person_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_person = table.Column<int>(type: "int", nullable: false),
                    id_address = table.Column<int>(type: "int", nullable: false),
                    is_physical = table.Column<bool>(type: "bit", nullable: false),
                    is_billing = table.Column<bool>(type: "bit", nullable: false),
                    is_administrative = table.Column<bool>(type: "bit", nullable: false),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_address", x => x.id_person_address);
                });

            migrationBuilder.CreateTable(
                name: "site",
                columns: table => new
                {
                    id_site = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    short_description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    is_master_site = table.Column<bool>(type: "bit", nullable: false),
                    parent_id = table.Column<bool>(type: "bit", nullable: false),
                    language_default = table.Column<int>(type: "int", nullable: false),
                    facebook_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twitter_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    youtube_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instagram_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_site", x => x.id_site);
                });

            migrationBuilder.CreateTable(
                name: "site_address",
                columns: table => new
                {
                    id_site_address = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_site = table.Column<int>(type: "int", nullable: false),
                    id_address = table.Column<int>(type: "int", nullable: false),
                    is_physical = table.Column<bool>(type: "bit", nullable: false),
                    is_billing = table.Column<bool>(type: "bit", nullable: false),
                    is_administrative = table.Column<bool>(type: "bit", nullable: false),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_site_address", x => x.id_site_address);
                });

            migrationBuilder.CreateTable(
                name: "site_business",
                columns: table => new
                {
                    id_site_business = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_site = table.Column<int>(type: "int", nullable: false),
                    id_business = table.Column<int>(type: "int", nullable: false),
                    internal_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by_id = table.Column<int>(type: "int", nullable: false),
                    created_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    make_active_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deactivated_by_id = table.Column<int>(type: "int", nullable: true),
                    deactivate_datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invisible = table.Column<bool>(type: "bit", nullable: false),
                    inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_site_business", x => x.id_site_business);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "business");

            migrationBuilder.DropTable(
                name: "business_address");

            migrationBuilder.DropTable(
                name: "business_person");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "person_address");

            migrationBuilder.DropTable(
                name: "site");

            migrationBuilder.DropTable(
                name: "site_address");

            migrationBuilder.DropTable(
                name: "site_business");
        }
    }
}
