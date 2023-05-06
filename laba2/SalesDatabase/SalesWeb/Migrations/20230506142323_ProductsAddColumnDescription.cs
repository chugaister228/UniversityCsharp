using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWeb.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAddColumnDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                defaultValue: "No description");

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
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5463-4939-2462-7744", "Octavia.Medhurst36@yahoo.com", "Elta" });

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
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Generic Rubber Bacon", 2071, 8 });

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
                columns: new[] { "Name", "Price" },
                values: new object[] { "Rustic Granite Gloves", 340 });

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
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 8, 30, 21, 14, 55, 169, DateTimeKind.Local).AddTicks(7369), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateTime(2022, 9, 16, 6, 28, 28, 973, DateTimeKind.Local).AddTicks(5933), 3, 2 });

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
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 9, new DateTime(2023, 2, 19, 12, 6, 31, 800, DateTimeKind.Local).AddTicks(1445), 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 2, 13, 1, 25, 57, 577, DateTimeKind.Local).AddTicks(1635), 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2023, 4, 25, 9, 38, 50, 553, DateTimeKind.Local).AddTicks(7167), 9, 8 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 9, 14, 6, 57, 2, 715, DateTimeKind.Local).AddTicks(2495), 10 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "63049746141772953", "Gerson_Abbott@yahoo.com", "Sonny" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3709-925256-01753", "Briana.Borer47@gmail.com", "Brannon" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-6280-1531-9801-89", "Payton.Howell18@yahoo.com", "Rowland" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-1898-3803-6803-694", "Angeline.Hackett@gmail.com", "Chelsea" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3649-070130-8257", "Alexa35@hotmail.com", "Trycia" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "3029-512461-0189", "Lois65@hotmail.com", "Ethan" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6759-7246-5079-2296-933", "Junior.Senger66@yahoo.com", "Justus" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6011-6241-3363-1874-0816", "Clementine83@hotmail.com", "Bessie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "5018537233701275311", "Jay76@gmail.com", "Preston" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CreditCardNumber", "Email", "Name" },
                values: new object[] { "6767-0114-1451-7535-298", "Lindsay.Keebler@gmail.com", "Amir" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Generic Metal Tuna", 4880, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handmade Frozen Keyboard", 1833, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Unbranded Wooden Sausages", 4543, 8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Tasty Plastic Car", 3999, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Small Steel Table", 1106, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Generic Cotton Pants", 4375, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Fantastic Wooden Car", 478 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handcrafted Metal Sausages", 2003, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Handcrafted Granite Towels", 1339, 7 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Name", "Price", "Quantity" },
                values: new object[] { "Incredible Plastic Gloves", 675, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 1,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateTime(2022, 5, 8, 6, 22, 32, 549, DateTimeKind.Local).AddTicks(602), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 2,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 8, new DateTime(2023, 1, 13, 20, 44, 3, 810, DateTimeKind.Local).AddTicks(5455), 9, 1 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 3,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 6, new DateTime(2023, 2, 6, 22, 32, 43, 297, DateTimeKind.Local).AddTicks(6970), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 4,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 9, new DateTime(2023, 3, 10, 17, 23, 43, 616, DateTimeKind.Local).AddTicks(3776), 9, 10 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 5,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateTime(2023, 2, 22, 5, 53, 40, 66, DateTimeKind.Local).AddTicks(1480), 5, 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 6,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 2, new DateTime(2023, 1, 9, 3, 3, 41, 20, DateTimeKind.Local).AddTicks(1402), 6, 8 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 7,
                columns: new[] { "CustomerId", "Date", "ProductId" },
                values: new object[] { 8, new DateTime(2022, 6, 11, 9, 32, 22, 336, DateTimeKind.Local).AddTicks(8675), 5 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 8,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 8, new DateTime(2022, 11, 8, 2, 53, 55, 593, DateTimeKind.Local).AddTicks(7394), 7 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 9,
                columns: new[] { "CustomerId", "Date", "ProductId", "StoreId" },
                values: new object[] { 3, new DateTime(2023, 3, 30, 4, 56, 34, 342, DateTimeKind.Local).AddTicks(5297), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "SaleId",
                keyValue: 10,
                columns: new[] { "CustomerId", "Date", "StoreId" },
                values: new object[] { 10, new DateTime(2022, 12, 10, 16, 21, 24, 208, DateTimeKind.Local).AddTicks(6766), 7 });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 1,
                column: "Name",
                value: "Beier LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 2,
                column: "Name",
                value: "Kilback Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 3,
                column: "Name",
                value: "Olson, Hammes and Haag");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 4,
                column: "Name",
                value: "Walker LLC");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 5,
                column: "Name",
                value: "Kassulke Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 6,
                column: "Name",
                value: "Heller - Erdman");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 7,
                column: "Name",
                value: "Powlowski and Sons");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 8,
                column: "Name",
                value: "Beatty Group");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 9,
                column: "Name",
                value: "Reynolds, Mante and Stamm");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 10,
                column: "Name",
                value: "Grant - Heidenreich");
        }
    }
}
