using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Abstractions.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticlePraises",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    MemberId = table.Column<string>(maxLength: 20, nullable: false),
                    BlogNum = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePraises", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Blogcontents",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    BloginfoNum = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogcontents", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Categorypics",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    CategoryId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorypics", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    FatherId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Memberid = table.Column<string>(maxLength: 50, nullable: false),
                    MemberName = table.Column<string>(maxLength: 500, nullable: false),
                    BlogNum = table.Column<string>(maxLength: 50, nullable: false),
                    Commentid = table.Column<string>(maxLength: 50, nullable: false),
                    ToMemberid = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(maxLength: 500, nullable: false),
                    Avatar = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    UserName = table.Column<string>(maxLength: 500, nullable: false),
                    UserAcount = table.Column<string>(maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(maxLength: 500, nullable: false),
                    UserNikeName = table.Column<string>(maxLength: 500, nullable: false),
                    IsAdmin = table.Column<int>(nullable: false),
                    LastUpTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "HotNews",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Url = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotNews", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Logintokens",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<int>(nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<int>(nullable: false, defaultValue: 0),
                    CreateUserId = table.Column<string>(nullable: true),
                    CreateUserName = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<string>(nullable: true),
                    UpdateUserName = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Extend1 = table.Column<int>(nullable: true),
                    Extend2 = table.Column<int>(nullable: true),
                    Extend3 = table.Column<int>(nullable: true),
                    Extend4 = table.Column<string>(nullable: true),
                    Extend5 = table.Column<string>(nullable: true),
                    Extend6 = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    TokenExpiration = table.Column<string>(nullable: true),
                    LoginUserId = table.Column<string>(nullable: true),
                    LoginUserAccount = table.Column<string>(nullable: true),
                    LoginUserType = table.Column<int>(nullable: false),
                    IpAddr = table.Column<string>(nullable: true),
                    PlatForm = table.Column<int>(nullable: false),
                    IsLogOut = table.Column<int>(nullable: false),
                    LoginResult = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logintokens", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Url = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    UserName = table.Column<string>(nullable: true),
                    UserAccount = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Operationlogs",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<string>(nullable: true),
                    UpdateUserName = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Extend1 = table.Column<int>(nullable: true),
                    Extend2 = table.Column<int>(nullable: true),
                    Extend3 = table.Column<int>(nullable: true),
                    Extend4 = table.Column<string>(nullable: true),
                    Extend5 = table.Column<string>(nullable: true),
                    Extend6 = table.Column<string>(nullable: true),
                    TableName = table.Column<string>(nullable: true),
                    TablePriKeyField = table.Column<string>(nullable: true),
                    TablePriKeyValue = table.Column<string>(nullable: true),
                    IpAddr = table.Column<string>(nullable: true),
                    ReqData = table.Column<string>(nullable: true),
                    ResOldData = table.Column<string>(nullable: true),
                    ResResult = table.Column<string>(nullable: true),
                    OperType = table.Column<int>(nullable: false),
                    OperResult = table.Column<int>(nullable: false),
                    LogContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operationlogs", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Sysmenus",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Menuname = table.Column<string>(maxLength: 500, nullable: false),
                    Menuremark = table.Column<string>(maxLength: 500, nullable: false),
                    MenuUrl = table.Column<string>(maxLength: 500, nullable: false),
                    Menuicon = table.Column<string>(maxLength: 500, nullable: false),
                    Menusort = table.Column<int>(nullable: false),
                    Fatherid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysmenus", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Sysroles",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Rolename = table.Column<string>(maxLength: 500, nullable: false),
                    Roleremark = table.Column<string>(maxLength: 500, nullable: false),
                    MenuList = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysroles", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "WxUsers",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Openid = table.Column<string>(maxLength: 500, nullable: false),
                    NickName = table.Column<string>(maxLength: 50, nullable: false),
                    Sex = table.Column<string>(maxLength: 50, nullable: false),
                    Province = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    HeadImgUrl = table.Column<string>(maxLength: 500, nullable: false),
                    Privilege = table.Column<string>(maxLength: 500, nullable: false),
                    Unionid = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxUsers", x => x.KID);
                });

            migrationBuilder.CreateTable(
                name: "Bloginfos",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend2 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend3 = table.Column<int>(nullable: false, defaultValue: 0),
                    Extend4 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend5 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    Extend6 = table.Column<string>(maxLength: 128, nullable: false, defaultValue: ""),
                    BlogNum = table.Column<string>(maxLength: 50, nullable: false),
                    Title = table.Column<string>(maxLength: 500, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    IsTop = table.Column<int>(nullable: false),
                    IsPrivate = table.Column<int>(nullable: false),
                    IsOriginal = table.Column<int>(nullable: false),
                    Vesion = table.Column<string>(nullable: true),
                    Blogimg = table.Column<string>(nullable: true),
                    Sorc = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    Start = table.Column<int>(nullable: false),
                    Views = table.Column<int>(nullable: false, defaultValue: 1),
                    Comments = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloginfos", x => x.KID);
                    table.ForeignKey(
                        name: "FK_Bloginfos_Categorys_Type",
                        column: x => x.Type,
                        principalTable: "Categorys",
                        principalColumn: "KID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sysuserroles",
                columns: table => new
                {
                    KID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    States = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    IsDeleted = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValue: (sbyte)0),
                    CreateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "1"),
                    CreateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: "System"),
                    CreateTime = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)),
                    UpdateUserId = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateUserName = table.Column<string>(maxLength: 512, nullable: false, defaultValue: ""),
                    UpdateTime = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Extend1 = table.Column<int>(nullable: true),
                    Extend2 = table.Column<int>(nullable: true),
                    Extend3 = table.Column<int>(nullable: true),
                    Extend4 = table.Column<string>(nullable: true),
                    Extend5 = table.Column<string>(nullable: true),
                    Extend6 = table.Column<string>(nullable: true),
                    Userid = table.Column<int>(nullable: false),
                    Roleid = table.Column<int>(nullable: false),
                    UserType = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysuserroles", x => x.KID);
                    table.ForeignKey(
                        name: "FK_Sysuserroles_Sysroles_Roleid",
                        column: x => x.Roleid,
                        principalTable: "Sysroles",
                        principalColumn: "KID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sysuserroles_Employees_Userid",
                        column: x => x.Userid,
                        principalTable: "Employees",
                        principalColumn: "KID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "KID", "CreateTime", "Description", "FatherId", "Name", "UpdateTime", "UpdateUserId", "UpdateUserName" },
                values: new object[] { 1, new DateTime(2019, 9, 9, 9, 9, 9, 0, DateTimeKind.Unspecified), 0, 0, "efcore", new DateTime(2020, 3, 4, 22, 34, 45, 7, DateTimeKind.Local).AddTicks(5211), "1", "System内置" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "KID", "CreateTime", "IsAdmin", "LastUpTime", "UpdateTime", "UpdateUserId", "UpdateUserName", "UserAcount", "UserName", "UserNikeName", "UserPassword" },
                values: new object[] { 1, new DateTime(2019, 9, 9, 9, 9, 9, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 4, 22, 34, 45, 27, DateTimeKind.Local).AddTicks(5802), "1", "System内置", "123", "超级管理员", "超管", "202CB962AC59075B964B07152D234B70" });

            migrationBuilder.CreateIndex(
                name: "IX_Bloginfos_Type",
                table: "Bloginfos",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_Sysuserroles_Roleid",
                table: "Sysuserroles",
                column: "Roleid");

            migrationBuilder.CreateIndex(
                name: "IX_Sysuserroles_Userid",
                table: "Sysuserroles",
                column: "Userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePraises");

            migrationBuilder.DropTable(
                name: "Blogcontents");

            migrationBuilder.DropTable(
                name: "Bloginfos");

            migrationBuilder.DropTable(
                name: "Categorypics");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "HotNews");

            migrationBuilder.DropTable(
                name: "Logintokens");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Operationlogs");

            migrationBuilder.DropTable(
                name: "Sysmenus");

            migrationBuilder.DropTable(
                name: "Sysuserroles");

            migrationBuilder.DropTable(
                name: "WxUsers");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Sysroles");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
