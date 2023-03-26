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
                    { 1, "Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6306), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6315) },
                    { 2, "Puma", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6317) },
                    { 3, "Nike", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6318), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6319) },
                    { 4, "Diadora", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6319), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6320) },
                    { 5, "The North Face", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6320), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6321) },
                    { 6, "Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6322), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6323) },
                    { 7, "Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6323), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6324) },
                    { 8, "Vans", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6324), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6324) },
                    { 9, "Reebook", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6325) },
                    { 10, "Converse", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6327) },
                    { 11, "ТВОЕ", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6328) },
                    { 12, "Mark Formelle", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6329) }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName", "CreatedDate", "DeletedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Белый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6388), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6389) },
                    { 2, "Черный", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6409) },
                    { 3, "Желтый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6409), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6409) },
                    { 4, "Коричневый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6410) },
                    { 5, "Розовый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6414), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6414) },
                    { 6, "Бежевый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6416), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6416) },
                    { 7, "Серый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6417) },
                    { 8, "Зеленый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6418) },
                    { 9, "Синий", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6418), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6419) },
                    { 10, "Фиолетовый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6420), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6420) },
                    { 11, "Красный", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6421) },
                    { 12, "Оранжевый", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6422) }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "CreatedDate", "DeletedDate", "GenderName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6472), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6473) },
                    { 2, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6476) }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "CreatedDate", "DeletedDate", "Index", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Витебск", "Беларусь", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6566), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6566) },
                    { 2, "Москва", "Россия", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6571), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6571) },
                    { 3, "Киев", "Украина", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6572) },
                    { 4, "Могилев", "Беларусь", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6573), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6573) },
                    { 5, "Минск", "Беларусь", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "210021", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6575) }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "SeasonId", "CreatedDate", "DeletedDate", "SeasonName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6521), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Демисезон", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6521) },
                    { 2, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Весна", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6524) },
                    { 3, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6524), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Зима", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6524) },
                    { 4, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Осень", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6525) },
                    { 5, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6526), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Лето", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6526) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LocationId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48701", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 1, false, null, null, null, "AQAAAAEAACcQAAAAEP9tfDrMeXhTcSNOK4ZvChJUmRJItt9sErtW/Kv2+5qH1cWaXHwHQAstiixTLIBh8g==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6672), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "mkr.e" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48702", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 2, false, null, null, null, "AQAAAAEAACcQAAAAEP9tfDrMeXhTcSNOK4ZvChJUmRJItt9sErtW/Kv2+5qH1cWaXHwHQAstiixTLIBh8g==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6681), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Andrey" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48703", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 3, false, null, null, null, "AQAAAAEAACcQAAAAEP9tfDrMeXhTcSNOK4ZvChJUmRJItt9sErtW/Kv2+5qH1cWaXHwHQAstiixTLIBh8g==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6687), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Vitali" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48704", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 4, false, null, null, null, "AQAAAAEAACcQAAAAEP9tfDrMeXhTcSNOK4ZvChJUmRJItt9sErtW/Kv2+5qH1cWaXHwHQAstiixTLIBh8g==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6694), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Alexandr" },
                    { "3046bb27-a9f9-4cfb-87ee-0853cae48705", 0, "b84f97b2-007f-4781-9ee7-9dcedd5185d3", null, false, 5, false, null, null, null, "AQAAAAEAACcQAAAAEP9tfDrMeXhTcSNOK4ZvChJUmRJItt9sErtW/Kv2+5qH1cWaXHwHQAstiixTLIBh8g==", null, false, "7iK7mWYVQgEriP+Zoia/UfiMKon/4cqUijRncBrplJpt1C0CJDZkstZsXTtnF4SMsv9Wfv+HU2fErMvHjTPW4g==", new DateTime(2023, 3, 27, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6700), "DKOIJFTBZLFCJCNGXCZ3AZRQ4BZ2K5SA", false, "Vasilisa" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BrandId", "CreatedDate", "DeletedDate", "Description", "GenderId", "Image", "Price", "ProductName", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6750), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Практичная и прочная обувь.", 1, "https://avatars.mds.yandex.net/get-mpic/7543961/img_id2876985684977519291.jpeg/orig", 80m, "Кеды Converse", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6751), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 2, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6753), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6753), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 3, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6754), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6755), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 4, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6755), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 5, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6756), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6757), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 6, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6758), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6758), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 7, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6759), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6760), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 8, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6778), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6779), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 9, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6780), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6780), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 10, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6782), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6782), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 11, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6783), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6783), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 12, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6784), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6784), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 13, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6785), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6786), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 14, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6786), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6787), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 15, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6788), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6788), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 16, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6789), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6789), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 17, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6790), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6790), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 18, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6793), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6794), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 19, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6796), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6796), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 20, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6797), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 21, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6798), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6799), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 22, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6799), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6800), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 23, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6801), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6801), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 24, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6802), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6802), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 25, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6803), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6806), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 26, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6807), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6807), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 27, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6808), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6808), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 28, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6809), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6809), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 29, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6810), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6811), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 30, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6812), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6812), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 31, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6813), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6813), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 32, 1, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6814), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Основная часть кроссовок изготовлена из устойчивых к износу материалов.", 2, "https://basket-10.wb.ru/vol1492/part149253/149253341/images/big/3.jpg", 175m, "Кроссовки Adidas", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6814), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 33, 6, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6815), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Изделие из фактурного хлопкового трикотажа украшено вышивкой с принтом на груди", 1, "https://a.lmcdn.ru/product/R/T/RTLABL206701_17128948_1_v1_2x.jpg", 289m, "Футболка Fred Perry", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6815), "3046bb27-a9f9-4cfb-87ee-0853cae48701" },
                    { 34, 7, new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6817), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Кроссовки выполнены из сетчатого текстиля, растягивается при естественном движении стопы и создает удобную посадку. ", 1, "https://a.lmcdn.ru/product/R/T/RTLACH890601_19173162_1_v1.jpg", 486m, "Кроссовки Asics", new DateTime(2023, 3, 26, 16, 6, 53, 301, DateTimeKind.Local).AddTicks(6818), "3046bb27-a9f9-4cfb-87ee-0853cae48701" }
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
