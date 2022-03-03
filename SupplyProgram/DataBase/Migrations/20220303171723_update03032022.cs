using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class update03032022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "ScaleValue",
                columns: table => new
                {
                    ScaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScalesTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScaleValue", x => x.ScaleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UsersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UsersID);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ScaleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageID);
                    table.ForeignKey(
                        name: "FK_Packages_ScaleValue",
                        column: x => x.ScaleID,
                        principalTable: "ScaleValue",
                        principalColumn: "ScaleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductStatus1",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    PackageID = table.Column<int>(type: "int", nullable: true),
                    UnitInstock = table.Column<int>(type: "int", nullable: true),
                    UnitinOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStatus1", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_ProductStatus1_Locations",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStatus1_Packages",
                        column: x => x.PackageID,
                        principalTable: "Packages",
                        principalColumn: "PackageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductStatus1_Products",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "Location" },
                values: new object[,]
                {
                    { 1, "HOME 1" },
                    { 2, "HOME 2" },
                    { 3, "STORE" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductName" },
                values: new object[,]
                {
                    { 7, "Spicy Paprika" },
                    { 5, "Cumin" },
                    { 4, "Hot-red-chili flakes" },
                    { 6, "Ground ginger" },
                    { 2, "Ground cinnamon" },
                    { 1, "Black peppercorns" },
                    { 3, "Chili powder" }
                });

            migrationBuilder.InsertData(
                table: "ScaleValue",
                columns: new[] { "ScaleID", "ScalesTypes" },
                values: new object[,]
                {
                    { 1, "5 kg" },
                    { 2, "10 kg" },
                    { 3, "500 g" },
                    { 4, "300 g" },
                    { 5, "100 g" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UsersID", "Admin", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, true, "admin@gmail.com", "Aa123456", "Admin" },
                    { 2, true, "User2@gmail.com", "Aa123456", "User1" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageID", "PackageType", "ScaleID" },
                values: new object[,]
                {
                    { 1, "BOX 1", 1 },
                    { 3, "Bag 1", 1 },
                    { 2, "BOX 3", 2 },
                    { 5, "Small Bag 1", 2 },
                    { 6, "Small Bag 2", 3 },
                    { 7, "BOX 3", 4 },
                    { 4, "Bag 2", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductStatus1",
                columns: new[] { "StatusID", "LocationID", "PackageID", "ProductID", "UnitInstock", "UnitinOrder" },
                values: new object[,]
                {
                    { 2, 1, 1, 5, 15, 30 },
                    { 5, 2, 1, 3, 15, 30 },
                    { 6, 1, 1, 1, 10, 15 },
                    { 1, 1, 3, 2, 10, 30 },
                    { 3, 2, 3, 3, 20, 25 },
                    { 4, 3, 4, 6, 15, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_ScaleID",
                table: "Packages",
                column: "ScaleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStatus1_LocationID",
                table: "ProductStatus1",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStatus1_PackageID",
                table: "ProductStatus1",
                column: "PackageID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStatus1_ProductID",
                table: "ProductStatus1",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductStatus1");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ScaleValue");
        }
    }
}
