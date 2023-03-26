using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClothingStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Index = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeasonName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    ColorsColorId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => new { x.ColorsColorId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_ColorProduct_Colors_ColorsColorId",
                        column: x => x.ColorsColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeason",
                columns: table => new
                {
                    ProductsProductId = table.Column<int>(type: "int", nullable: false),
                    SeasonsSeasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeason", x => new { x.ProductsProductId, x.SeasonsSeasonId });
                    table.ForeignKey(
                        name: "FK_ProductSeason_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSeason_Seasons_SeasonsSeasonId",
                        column: x => x.SeasonsSeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7374), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7387) },
                    { 2, "Puma", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7390), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7390) },
                    { 3, "Nike", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7391) },
                    { 4, "Diadora", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7392), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7392) },
                    { 5, "The North Face", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7394) },
                    { 6, "Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7395), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7396) },
                    { 7, "Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7397) },
                    { 8, "Vans", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7397), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7398) },
                    { 9, "Reebook", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7434), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7435) },
                    { 10, "Converse", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7437), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7437) },
                    { 11, "ТВОЕ", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7438), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7438) },
                    { 12, "Mark Formelle", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7439), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7439) }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Белый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7524), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7524) },
                    { 2, "Черный", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7527), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7527) },
                    { 3, "Желтый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7528), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7528) },
                    { 4, "Коричневый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7529) },
                    { 5, "Розовый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7529), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7530) },
                    { 6, "Бежевый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7531), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7532) },
                    { 7, "Серый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7532), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7532) },
                    { 8, "Зеленый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7533), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7533) },
                    { 9, "Синий", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7534) },
                    { 10, "Фиолетовый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7536), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7536) },
                    { 11, "Красный", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7537) },
                    { 12, "Оранжевый", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7538), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7538) }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "CreatedDate", "DeletedDate", "GenderName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7591), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7592) },
                    { 2, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7595) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "CreatedDate", "DeletedDate", "Index", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Витебск", "Беларусь", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7696) },
                    { 2, "Москва", "Россия", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7698), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7699) },
                    { 3, "Киев", "Украина", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7700), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7700) },
                    { 4, "Могилев", "Беларусь", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7701) },
                    { 5, "Минск", "Беларусь", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7702), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7702) }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "CreatedDate", "DeletedDate", "SeasonName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Демисезон", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7647) },
                    { 2, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Весна", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7649) },
                    { 3, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7649), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Зима", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7650) },
                    { 4, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7650), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Осень", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7651) },
                    { 5, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7651), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Лето", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7652) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LocationId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48701", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 1, false, null, null, null, "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7808), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "mkr.e" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48702", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 2, false, null, null, null, "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7834), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Andrey" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48703", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 3, false, null, null, null, "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7840), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Vitali" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48704", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 4, false, null, null, null, "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7845), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Alexandr" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48705", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 5, false, null, null, null, "AQAAAAEAACcQAAAAELXiNd8dU7e8G/cZwkZYkUwRQI1W98Nfl4ZeYH/ax0gk1kuzcvSY4tf2hP4y8o39cw==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7853), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Vasilisa" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CreatedDate", "DeletedDate", "Description", "GenderId", "Image", "Price", "ProductName", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7934), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Практичная и прочная обувь.", 1, "https://avatars.mds.yandex.net/get-mpic/7543961/img_id2876985684977519291.jpeg/orig", 80m, "Кеды Converse", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7935), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 2, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7938), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7938), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 3, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7940), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 4, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7940), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 5, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7941), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7942), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 6, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7943), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7944), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 7, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7945), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7945), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 8, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7947), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7948), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 9, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7949), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7949), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 10, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7951), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7951), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 11, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7952), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7952), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 12, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7954), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7955), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 13, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7956), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7956), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 14, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7957), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7958), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 15, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7960), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7960), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 16, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7961), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7962), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 17, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7965), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7965), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 18, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7967), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7967), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 19, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7968), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7969), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 20, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7970), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7970), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 21, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7972), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7972), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 22, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7973), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7974), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 23, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7975), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7975), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 24, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7976), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7976), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 25, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7977), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7977), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 26, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7978), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7979), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 27, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7980), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7980), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 28, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7981), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7981), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 29, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7982), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7983), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 30, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7984), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 31, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7985), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7985), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 32, 1, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7986), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7987), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 33, 6, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7987), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7988), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 34, 7, new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 18, 52, 51, 170, DateTimeKind.Local).AddTicks(7990), "3046bb27-a9f9-4cfb-87ee-0853cae48701" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BrandId",
                table: "Brands",
                column: "BrandId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductsProductId",
                table: "ColorProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ColorId",
                table: "Colors",
                column: "ColorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genders_GenderId",
                table: "Genders",
                column: "GenderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationId",
                table: "Locations",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderId",
                table: "Products",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeason_SeasonsSeasonId",
                table: "ProductSeason",
                column: "SeasonsSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SeasonId",
                table: "Seasons",
                column: "SeasonId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropTable(
                name: "ProductSeason");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
