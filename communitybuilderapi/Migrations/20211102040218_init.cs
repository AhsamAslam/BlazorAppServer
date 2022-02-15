using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace communitybuilderapi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressSuite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressZipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessAddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortIndex = table.Column<int>(type: "int", nullable: true),
                    BusinessNumber = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    NumberOfFans = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Offers = table.Column<bool>(type: "bit", nullable: true),
                    SearchTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    LocallyOwned = table.Column<int>(type: "int", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessID);
                });

            migrationBuilder.CreateTable(
                name: "BusinessComments",
                columns: table => new
                {
                    BusinessCommentID = table.Column<int>(type: "int", nullable: false),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessComments", x => x.BusinessCommentID);
                });

            migrationBuilder.CreateTable(
                name: "BusinessCommentSub",
                columns: table => new
                {
                    SubCommentID = table.Column<int>(type: "int", nullable: false),
                    CommentID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessCommentSub", x => x.SubCommentID);
                });

            migrationBuilder.CreateTable(
                name: "BusinessEvents",
                columns: table => new
                {
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessEvents", x => new { x.BusinessID, x.EventID });
                });

            migrationBuilder.CreateTable(
                name: "BusinessFiles",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    FileURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortIndex = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stamp = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessFiles", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "ClientContacts",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientContacts", x => new { x.ClientID, x.ContactID });
                });

            migrationBuilder.CreateTable(
                name: "ClientSites",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSites", x => new { x.ClientID, x.SiteID });
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressSuite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameLong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultLanguageID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "CustomCss",
                columns: table => new
                {
                    CustomCssID = table.Column<int>(type: "int", nullable: false),
                    TextColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontFamily = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextDecoration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackGroundColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SitePageID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomCss", x => x.CustomCssID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false),
                    VirtualOrPhysical = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VirtualType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hyperlink1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hyperlink2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    DeactivateOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeactivatedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "Fans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    ThisWeek = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FundingPlan",
                columns: table => new
                {
                    FundingPlanID = table.Column<int>(type: "int", nullable: false),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    FundingTypeID = table.Column<int>(type: "int", nullable: false),
                    PlanTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanPublicizeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanFulfilledDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingPlan", x => x.FundingPlanID);
                });

            migrationBuilder.CreateTable(
                name: "FundingPlanInvestor",
                columns: table => new
                {
                    FundingPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestorUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingPlanInvestor", x => x.FundingPlanID);
                });

            migrationBuilder.CreateTable(
                name: "FundingType",
                columns: table => new
                {
                    FundingTypeID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundingType", x => x.FundingTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageDescNative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Localization",
                columns: table => new
                {
                    LocalizationID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization", x => x.LocalizationID);
                });

            migrationBuilder.CreateTable(
                name: "LocalizationKeyValues",
                columns: table => new
                {
                    KeyValueID = table.Column<int>(type: "int", nullable: false),
                    LocalizationID = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalizationKeyValues", x => x.KeyValueID);
                });

            migrationBuilder.CreateTable(
                name: "Referral",
                columns: table => new
                {
                    ReferrerUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReferredUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referral", x => new { x.ReferredUserID, x.ReferrerUserID });
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMasterSite = table.Column<bool>(type: "bit", nullable: false),
                    ParentID = table.Column<int>(type: "int", nullable: true),
                    DefaultLanguageID = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByID = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedByID = table.Column<int>(type: "int", nullable: false),
                    UpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteID);
                });

            migrationBuilder.CreateTable(
                name: "SiteEvents",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteEvents", x => new { x.SiteID, x.EventID });
                });

            migrationBuilder.CreateTable(
                name: "SiteHeader",
                columns: table => new
                {
                    SiteHeaderID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    SitePageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteHeader", x => x.SiteHeaderID);
                });

            migrationBuilder.CreateTable(
                name: "SitePage",
                columns: table => new
                {
                    SitePageID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitePage", x => x.SitePageID);
                });

            migrationBuilder.CreateTable(
                name: "xStage1",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_OLd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xStage1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "xStage2",
                columns: table => new
                {
                    Stage2ID = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xStage2", x => x.Stage2ID);
                });
            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "uniqueidentifier", nullable: false),
                    FileOriginalName = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    FileType = table.Column<int>(type: "nvarchar(50)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    FileSize = table.Column<string>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "GenericLocalizationKeyValues",
                columns: table => new
                {
                    KeyValueID = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericLocalizationKeyValues", x => x.KeyValueID);
                    table.ForeignKey(
                        name: "FK_GenericLocalizationKeyValues_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenericLocalizationKeyValues_LanguageId",
                table: "GenericLocalizationKeyValues",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "BusinessComments");

            migrationBuilder.DropTable(
                name: "BusinessCommentSub");

            migrationBuilder.DropTable(
                name: "BusinessEvents");

            migrationBuilder.DropTable(
                name: "BusinessFiles");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "ClientContacts");

            migrationBuilder.DropTable(
                name: "ClientSites");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "CustomCss");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Fans");

            migrationBuilder.DropTable(
                name: "FundingPlan");

            migrationBuilder.DropTable(
                name: "FundingPlanInvestor");

            migrationBuilder.DropTable(
                name: "FundingType");

            migrationBuilder.DropTable(
                name: "GenericLocalizationKeyValues");

            migrationBuilder.DropTable(
                name: "Localization");

            migrationBuilder.DropTable(
                name: "LocalizationKeyValues");

            migrationBuilder.DropTable(
                name: "Referral");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "SiteEvents");

            migrationBuilder.DropTable(
                name: "SiteHeader");

            migrationBuilder.DropTable(
                name: "SitePage");

            migrationBuilder.DropTable(
                name: "xStage1");

            migrationBuilder.DropTable(
                name: "xStage2");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
