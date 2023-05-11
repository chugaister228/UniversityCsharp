using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalesDatabase.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValue: "No description")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "CreditCardNumber", "Email", "Name" },
                values: new object[,]
                {
                    { new Guid("243eeeeb-3e6f-41aa-bef9-2cd38f804e97"), "6378-2684-1986-2499", "Terrell.Boyle@gmail.com", "Terrell" },
                    { new Guid("9646255f-7823-4cc8-8de9-c754f15b8317"), "5440-0402-5440-6120", "Tonya31@gmail.com", "Tonya" },
                    { new Guid("b934a5b7-ab63-4137-895d-52ab7bddafaa"), "3529-4022-7927-3712", "Wendell.Wunsch3@yahoo.com", "Wendell" },
                    { new Guid("bcc6f031-2b29-4825-8ca6-c724de2d9ad8"), "3050-322429-4238", "Bobbie.Denesik16@yahoo.com", "Bobbie" },
                    { new Guid("c6ff3481-b35a-4ff0-ac92-a6d413ac4738"), "5401-4940-9840-4998", "Eduardo.Muller@hotmail.com", "Eduardo" },
                    { new Guid("c8e1f825-369f-44f7-a1c5-b0b96d1b7acb"), "3577-8686-3904-0937", "Arnold_Swaniawski75@hotmail.com", "Arnold" },
                    { new Guid("cfbefd00-1520-46a9-868f-df3829eb8a8e"), "3577-5580-9093-5747", "Tabitha24@hotmail.com", "Tabitha" },
                    { new Guid("ec584c02-397c-4a19-8b6e-2745d53ac00f"), "6767-6797-8984-4678", "Cory60@yahoo.com", "Cory" },
                    { new Guid("f77947a7-abb1-4e9b-aec1-14ddf1012db7"), "3016-803185-9795", "Kristy22@gmail.com", "Kristy" },
                    { new Guid("f83b725a-3009-4226-a26f-8d20feaa2e54"), "6767-9727-6275-5858", "Melba.Nienow@yahoo.com", "Melba" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("283117dc-e030-49ab-8b1c-be00ebbfbb5a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Wooden Shirt", 3000m, 1 },
                    { new Guid("48362c85-cfd6-45a3-8799-0022cc8c0c8f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Soft Mouse", 2000m, 2 },
                    { new Guid("613c9453-da67-485a-bd4c-3bc825de5499"), "The Football Is Good For Training And Recreational Purposes", "Handmade Plastic Pants", 3000m, 4 },
                    { new Guid("6808d9c4-b736-40f3-a472-e4f8f52b135e"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Plastic Hat", 1000m, 3 },
                    { new Guid("86a7df10-1edc-4dbe-ae2d-b73e12497049"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Wooden Computer", 3000m, 5 },
                    { new Guid("9263de2e-d9ea-4970-a997-da58c98e7090"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Plastic Shoes", 2000m, 1 },
                    { new Guid("ba904973-4559-424c-9624-ccf027cfaab3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Granite Cheese", 1000m, 5 },
                    { new Guid("bb19a7da-76f2-4387-abd1-afb4882b1297"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Soft Towels", 1000m, 5 },
                    { new Guid("c04d7b3d-4b65-40f5-953b-71bab5ba92b1"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Frozen Hat", 1000m, 1 },
                    { new Guid("f6659400-4b2d-4b09-83b5-52e0156896bf"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Soft Car", 2000m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("012a5b97-435e-47cb-80e2-2dd85f5f6547"), "Farrell, Zulauf and Medhurst" },
                    { new Guid("25f7c7ae-2e49-4a2d-822b-83192f0c7fc6"), "Brakus, Breitenberg and Blick" },
                    { new Guid("31035ac9-39d8-449d-a39c-72e3adf7bc22"), "White LLC" },
                    { new Guid("8564f4d2-e570-4f52-bd22-c24f7c06bdeb"), "Herzog - Rodriguez" },
                    { new Guid("85d95378-116b-4710-be4c-78ed5474d66c"), "Littel LLC" },
                    { new Guid("cd7cb69d-c612-41d7-b087-7d769c6ca332"), "Schneider Inc" },
                    { new Guid("cda8b592-5eef-41f2-b021-1277bda89ae4"), "Maggio, Kirlin and Vandervort" },
                    { new Guid("cdcfaac2-caf4-48da-8d43-3124295da747"), "Keebler, Weimann and Huels" },
                    { new Guid("d4567875-d273-4f3e-a9e3-c0041ff060be"), "Feeney - Champlin" },
                    { new Guid("ec894c3b-959a-4d9b-a26e-a5b4cb38d9d1"), "Johns LLC" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "ID", "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("186562f1-d8be-4d00-91fd-5c8328716a6b"), new Guid("f77947a7-abb1-4e9b-aec1-14ddf1012db7"), new DateTime(2024, 4, 21, 10, 7, 59, 693, DateTimeKind.Local).AddTicks(6358), new Guid("6808d9c4-b736-40f3-a472-e4f8f52b135e"), new Guid("ec894c3b-959a-4d9b-a26e-a5b4cb38d9d1") },
                    { new Guid("38412591-2341-49b8-bcd1-748b61a75522"), new Guid("9646255f-7823-4cc8-8de9-c754f15b8317"), new DateTime(2024, 4, 4, 11, 54, 22, 625, DateTimeKind.Local).AddTicks(2792), new Guid("48362c85-cfd6-45a3-8799-0022cc8c0c8f"), new Guid("cdcfaac2-caf4-48da-8d43-3124295da747") },
                    { new Guid("4efa33b2-ac5d-4351-815d-9f77e40ce887"), new Guid("ec584c02-397c-4a19-8b6e-2745d53ac00f"), new DateTime(2024, 2, 11, 0, 20, 21, 60, DateTimeKind.Local).AddTicks(6452), new Guid("613c9453-da67-485a-bd4c-3bc825de5499"), new Guid("85d95378-116b-4710-be4c-78ed5474d66c") },
                    { new Guid("5d528fa3-cafb-457d-8908-c7c83be8e167"), new Guid("f83b725a-3009-4226-a26f-8d20feaa2e54"), new DateTime(2023, 7, 24, 2, 4, 3, 359, DateTimeKind.Local).AddTicks(1926), new Guid("86a7df10-1edc-4dbe-ae2d-b73e12497049"), new Guid("012a5b97-435e-47cb-80e2-2dd85f5f6547") },
                    { new Guid("60cb6cc6-4dc0-4fc9-bb7c-9fc867c8e9b5"), new Guid("b934a5b7-ab63-4137-895d-52ab7bddafaa"), new DateTime(2023, 12, 14, 15, 52, 52, 260, DateTimeKind.Local).AddTicks(6711), new Guid("bb19a7da-76f2-4387-abd1-afb4882b1297"), new Guid("25f7c7ae-2e49-4a2d-822b-83192f0c7fc6") },
                    { new Guid("8659afec-7d52-4e74-ad37-6176bda3aa6e"), new Guid("c8e1f825-369f-44f7-a1c5-b0b96d1b7acb"), new DateTime(2023, 8, 27, 1, 41, 46, 136, DateTimeKind.Local).AddTicks(8170), new Guid("c04d7b3d-4b65-40f5-953b-71bab5ba92b1"), new Guid("31035ac9-39d8-449d-a39c-72e3adf7bc22") },
                    { new Guid("86abf4ba-8159-4d52-9c6f-6fbe74283419"), new Guid("243eeeeb-3e6f-41aa-bef9-2cd38f804e97"), new DateTime(2023, 11, 11, 22, 32, 15, 905, DateTimeKind.Local).AddTicks(3414), new Guid("ba904973-4559-424c-9624-ccf027cfaab3"), new Guid("cda8b592-5eef-41f2-b021-1277bda89ae4") },
                    { new Guid("99c61b0d-2908-45b3-94f5-10c4791cebd5"), new Guid("cfbefd00-1520-46a9-868f-df3829eb8a8e"), new DateTime(2023, 9, 5, 5, 13, 9, 146, DateTimeKind.Local).AddTicks(8167), new Guid("9263de2e-d9ea-4970-a997-da58c98e7090"), new Guid("cd7cb69d-c612-41d7-b087-7d769c6ca332") },
                    { new Guid("b29e007e-d71a-4bb9-8d33-997c001658c9"), new Guid("c6ff3481-b35a-4ff0-ac92-a6d413ac4738"), new DateTime(2024, 2, 7, 8, 42, 43, 733, DateTimeKind.Local).AddTicks(7538), new Guid("f6659400-4b2d-4b09-83b5-52e0156896bf"), new Guid("d4567875-d273-4f3e-a9e3-c0041ff060be") },
                    { new Guid("c2f55458-62b8-44cd-8355-089179434e13"), new Guid("bcc6f031-2b29-4825-8ca6-c724de2d9ad8"), new DateTime(2024, 2, 17, 7, 2, 53, 393, DateTimeKind.Local).AddTicks(9477), new Guid("283117dc-e030-49ab-8b1c-be00ebbfbb5a"), new Guid("8564f4d2-e570-4f52-bd22-c24f7c06bdeb") }
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
