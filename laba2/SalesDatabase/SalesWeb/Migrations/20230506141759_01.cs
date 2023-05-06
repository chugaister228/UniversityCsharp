using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesWeb.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "63049746141772953", "Gerson_Abbott@yahoo.com", "Sonny" },
                    { 2, "3709-925256-01753", "Briana.Borer47@gmail.com", "Brannon" },
                    { 3, "6767-6280-1531-9801-89", "Payton.Howell18@yahoo.com", "Rowland" },
                    { 4, "6767-1898-3803-6803-694", "Angeline.Hackett@gmail.com", "Chelsea" },
                    { 5, "3649-070130-8257", "Alexa35@hotmail.com", "Trycia" },
                    { 6, "3029-512461-0189", "Lois65@hotmail.com", "Ethan" },
                    { 7, "6759-7246-5079-2296-933", "Junior.Senger66@yahoo.com", "Justus" },
                    { 8, "6011-6241-3363-1874-0816", "Clementine83@hotmail.com", "Bessie" },
                    { 9, "5018537233701275311", "Jay76@gmail.com", "Preston" },
                    { 10, "6767-0114-1451-7535-298", "Lindsay.Keebler@gmail.com", "Amir" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Generic Metal Tuna", 4880, 5 },
                    { 2, "Handmade Frozen Keyboard", 1833, 1 },
                    { 3, "Unbranded Wooden Sausages", 4543, 8 },
                    { 4, "Tasty Plastic Car", 3999, 7 },
                    { 5, "Small Steel Table", 1106, 6 },
                    { 6, "Generic Cotton Pants", 4375, 3 },
                    { 7, "Fantastic Wooden Car", 478, 7 },
                    { 8, "Handcrafted Metal Sausages", 2003, 1 },
                    { 9, "Handcrafted Granite Towels", 1339, 7 },
                    { 10, "Incredible Plastic Gloves", 675, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[,]
                {
                    { 1, "Beier LLC" },
                    { 2, "Kilback Group" },
                    { 3, "Olson, Hammes and Haag" },
                    { 4, "Walker LLC" },
                    { 5, "Kassulke Group" },
                    { 6, "Heller - Erdman" },
                    { 7, "Powlowski and Sons" },
                    { 8, "Beatty Group" },
                    { 9, "Reynolds, Mante and Stamm" },
                    { 10, "Grant - Heidenreich" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 5, 8, 6, 22, 32, 549, DateTimeKind.Local).AddTicks(602), 10, 4 },
                    { 2, 8, new DateTime(2023, 1, 13, 20, 44, 3, 810, DateTimeKind.Local).AddTicks(5455), 9, 1 },
                    { 3, 6, new DateTime(2023, 2, 6, 22, 32, 43, 297, DateTimeKind.Local).AddTicks(6970), 6, 3 },
                    { 4, 9, new DateTime(2023, 3, 10, 17, 23, 43, 616, DateTimeKind.Local).AddTicks(3776), 9, 10 },
                    { 5, 2, new DateTime(2023, 2, 22, 5, 53, 40, 66, DateTimeKind.Local).AddTicks(1480), 5, 7 },
                    { 6, 2, new DateTime(2023, 1, 9, 3, 3, 41, 20, DateTimeKind.Local).AddTicks(1402), 6, 8 },
                    { 7, 8, new DateTime(2022, 6, 11, 9, 32, 22, 336, DateTimeKind.Local).AddTicks(8675), 5, 2 },
                    { 8, 8, new DateTime(2022, 11, 8, 2, 53, 55, 593, DateTimeKind.Local).AddTicks(7394), 7, 7 },
                    { 9, 3, new DateTime(2023, 3, 30, 4, 56, 34, 342, DateTimeKind.Local).AddTicks(5297), 4, 9 },
                    { 10, 10, new DateTime(2022, 12, 10, 16, 21, 24, 208, DateTimeKind.Local).AddTicks(6766), 4, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_StoreId",
                table: "Sales",
                column: "StoreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
