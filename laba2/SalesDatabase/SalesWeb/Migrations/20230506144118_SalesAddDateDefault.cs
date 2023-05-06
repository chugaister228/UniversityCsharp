using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWeb.Migrations
{
    /// <inheritdoc />
    public partial class SalesAddDateDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "58935971388175067562", "Elsa29@hotmail.com", "Tamia" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5020756992298143", "Dakota.Feest@yahoo.com", "Percy" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3575-1533-6453-2941", "Oren89@gmail.com", "Jaylin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-8006-9790-9565", "Aurelia_Sauer86@yahoo.com", "Isom" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771-8903-9553-3738", "Alanna22@hotmail.com", "Ora" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5018589614353598", "Deontae.Pfeffer@yahoo.com", "Ines" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3010-527593-6798", "Chester.Beatty54@yahoo.com", "Micheal" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5445-3883-2176-8872", "Claude.Prohaska89@gmail.com", "Elian" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6378-3614-1562-7790", "Mozelle61@yahoo.com", "Jack" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email" },
                values: new object[] { "5595-6518-7128-6084", "Meda54@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Licensed Concrete Shirt", 1483, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Incredible Frozen Towels", 3730 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handcrafted Steel Gloves", 3096, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Metal Shirt", 4976, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Refined Concrete Keyboard", 1457, 9 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Concrete Pants", 1083, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Rubber Sausages", 2906, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Ergonomic Fresh Tuna", 4690, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Refined Soft Tuna", 1678, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Granite Shirt", 1100, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2022, 10, 17, 7, 57, 16, 768, DateTimeKind.Local).AddTicks(8108), 9, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 5, new DateTime(2022, 11, 25, 7, 25, 16, 913, DateTimeKind.Local).AddTicks(3272), 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 10, new DateTime(2022, 11, 8, 20, 30, 21, 228, DateTimeKind.Local).AddTicks(8068), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateTime(2023, 3, 5, 2, 26, 15, 381, DateTimeKind.Local).AddTicks(4937), 9, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 1, new DateTime(2022, 10, 9, 12, 9, 45, 38, DateTimeKind.Local).AddTicks(9000), 8, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 9, 25, 10, 41, 51, 98, DateTimeKind.Local).AddTicks(6307), 6, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 7, 10, 2, 58, 41, 57, DateTimeKind.Local).AddTicks(6957), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 7, new DateTime(2022, 6, 6, 17, 8, 15, 901, DateTimeKind.Local).AddTicks(3545), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2022, 10, 18, 5, 0, 2, 183, DateTimeKind.Local).AddTicks(8419), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateTime(2022, 6, 3, 1, 44, 15, 121, DateTimeKind.Local).AddTicks(2796), 7, 8 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Cummings LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Larson - Hane");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Parisian - Yundt");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Schuster - Kohler");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Senger LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Quitzon - Corkery");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Walter Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Wuckert and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Dare - Koepp");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Conn - Simonis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5020664876455492", "Scottie14@hotmail.com", "Lily" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3044-806386-2713", "Demond_Torp@gmail.com", "Wilford" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3470-174304-68872", "Loyce.Corkery69@gmail.com", "Joaquin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3528-7813-6672-5705", "Kade.White47@gmail.com", "Gussie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771-8981-8807-8068", "Bessie91@hotmail.com", "Lamont" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6380-1029-7202-7529", "Wilton.Fritsch@gmail.com", "Roman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6304-7583-1182-4000", "Frankie_Marks@gmail.com", "Garnet" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3463-609276-36580", "Effie46@hotmail.com", "Madisen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6771855043940021096", "Marian.Block@hotmail.com", "Danial" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email" },
                values: new object[] { "5463-4939-2462-7744", "Octavia.Medhurst36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Cotton Fish", 1905, 10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Generic Rubber Bacon", 2071 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Fantastic Granite Bike", 764, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Plastic Chair", 1272, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Concrete Pizza", 3729, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Ergonomic Steel Shirt", 2095, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Rustic Granite Gloves", 340, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Sleek Granite Gloves", 1639, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handmade Fresh Towels", 4799, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Practical Cotton Keyboard", 1049, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2022, 8, 30, 21, 14, 55, 169, DateTimeKind.Local).AddTicks(7369), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 2, new DateTime(2022, 9, 16, 6, 28, 28, 973, DateTimeKind.Local).AddTicks(5933), 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateTime(2022, 9, 15, 10, 26, 32, 360, DateTimeKind.Local).AddTicks(3164), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateTime(2022, 8, 16, 22, 33, 56, 566, DateTimeKind.Local).AddTicks(3224), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateTime(2023, 4, 16, 7, 56, 13, 268, DateTimeKind.Local).AddTicks(750), 6, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 5, new DateTime(2022, 5, 25, 0, 38, 39, 820, DateTimeKind.Local).AddTicks(8903), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 9, new DateTime(2023, 2, 19, 12, 6, 31, 800, DateTimeKind.Local).AddTicks(1445), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 2, 13, 1, 25, 57, 577, DateTimeKind.Local).AddTicks(1635), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "Date", "ProductId", "StoreId" },
                values: new object[] { new DateTime(2023, 4, 25, 9, 38, 50, 553, DateTimeKind.Local).AddTicks(7167), 9, 8 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 9, 14, 6, 57, 2, 715, DateTimeKind.Local).AddTicks(2495), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Jakubowski Inc");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Jenkins LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Nader - Hessel");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Lindgren, Bergnaum and Armstrong");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Blanda and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Borer and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Gleason - Ferry");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Bartoletti Inc");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Marks LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Daugherty Inc");
        }
    }
}
