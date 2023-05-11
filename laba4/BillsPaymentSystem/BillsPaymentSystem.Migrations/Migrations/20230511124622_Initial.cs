using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BillsPaymentSystem.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SwiftCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Limit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoneyOwed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    Password = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_CreditCards_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "ID", "Balance", "BankName", "CreatedDateTime", "SwiftCode", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("0004daeb-eb7a-44f4-aae6-c67bc5f80f62"), 901.15m, "Rolfson, Hermiston and Kessler", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(8134), "654", null },
                    { new Guid("043bbd7f-f38e-425a-afd0-d3fd6b07a0c9"), 726.60m, "Schmitt and Sons", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(2454), "544", null },
                    { new Guid("044e8d1f-ca5c-4130-907f-e41c5b72602c"), 36.80m, "Becker - Jenkins", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(9262), "514", null },
                    { new Guid("099c4e38-62bb-4bc4-b985-ac42af634dc9"), 211.36m, "Gerhold, Dach and Auer", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(2036), "733", null },
                    { new Guid("0f22d77f-025e-4438-ac79-6f79c5180ff6"), 589.05m, "O'Conner Group", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(3080), "397", null },
                    { new Guid("10e5255a-a916-47c7-9e88-aad6d9dff3ad"), 768.21m, "Klein and Sons", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(1085), "347", null },
                    { new Guid("167f8969-69aa-4072-8ef3-cfd1cd30847e"), 782.63m, "King LLC", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(4313), "052", null },
                    { new Guid("24713288-8319-46bf-b8c8-2141c3ff51d9"), 406.94m, "Schultz LLC", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(6246), "075", null },
                    { new Guid("24f911ff-4535-40ab-82fa-f6b2c1313b23"), 482.67m, "Dooley and Sons", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(5971), "083", null },
                    { new Guid("267eeddc-d642-41a3-b734-cfb06ae660de"), 964.13m, "Gaylord - Glover", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(2782), "887", null },
                    { new Guid("28175114-f33d-4987-b7b1-ae8b7f029737"), 629.83m, "Russel Group", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(1857), "415", null },
                    { new Guid("343aa821-a88f-4747-aa44-6790c907e81f"), 187.85m, "O'Kon, Douglas and Tromp", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(1970), "237", null },
                    { new Guid("367eb2a2-f9fa-453f-9611-ec6284f96cf7"), 76.43m, "Kutch Inc", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(1624), "813", null },
                    { new Guid("449a74c5-70af-40ac-8e85-a5cf70e63040"), 68.74m, "Rau Group", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(1412), "855", null },
                    { new Guid("4cccb7cc-0683-44bb-8883-003c815592a3"), 30.40m, "Grimes, Erdman and D'Amore", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(8884), "781", null },
                    { new Guid("4fc887bb-4cf6-4eb5-a0e2-40c03432f37f"), 21.26m, "Heaney, Stehr and Lueilwitz", new DateTime(2023, 5, 11, 15, 46, 21, 780, DateTimeKind.Local).AddTicks(9929), "045", null },
                    { new Guid("51992e7c-ca0d-46bf-bdb6-a50849ddde53"), 735.95m, "Okuneva, Oberbrunner and Satterfield", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(2587), "145", null },
                    { new Guid("51a6dbb0-30cb-412e-b170-b0c7430f3870"), 872.23m, "Langosh - Langosh", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(1333), "135", null },
                    { new Guid("53c84396-1508-4643-9d10-eb9fbcbaceb6"), 156.16m, "Armstrong, Bins and Wilkinson", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(9963), "059", null },
                    { new Guid("559bd96e-2721-456f-b794-ce36c5deb5cf"), 1.18m, "Ratke, Gleichner and Jakubowski", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(8239), "872", null },
                    { new Guid("55ad4561-d4e1-44e4-b68e-ee960951501d"), 744.33m, "Kessler LLC", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(742), "130", null },
                    { new Guid("56148dd8-1f62-4d20-b927-11406c44f133"), 812.64m, "Kris Inc", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(500), "827", null },
                    { new Guid("5666302d-9aef-4abe-bee0-903133c84428"), 849.17m, "Hilll, Prosacco and Von", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(8564), "310", null },
                    { new Guid("5744d96e-c16b-4426-b2eb-abab28eeed42"), 705.91m, "Boehm Group", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(8602), "530", null },
                    { new Guid("57750a84-1b63-401d-81e7-b23b08373d86"), 452.76m, "Kuhn, Maggio and Stoltenberg", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(2152), "613", null },
                    { new Guid("5d5f90d0-c58a-491d-9ccf-6e4c7eef0e39"), 585.19m, "Gibson - Barton", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(1083), "580", null },
                    { new Guid("634b798f-ae01-4942-bcf8-36c79b413bdd"), 70.98m, "Kerluke LLC", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(6533), "155", null },
                    { new Guid("6a994b72-9ca7-403e-8e0e-d63fb36df201"), 489.34m, "Morar - Cassin", new DateTime(2023, 5, 11, 15, 46, 21, 780, DateTimeKind.Local).AddTicks(9504), "567", null },
                    { new Guid("6c765818-72ca-44aa-ab71-64a8bcdc0f22"), 88.50m, "Emard, Blick and Goodwin", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(9567), "690", null },
                    { new Guid("6eba1ee3-3c3d-48ff-a45b-51efeba56879"), 959.11m, "Medhurst - Jacobson", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(1674), "988", null },
                    { new Guid("6eee4519-4f2d-4b3e-9ce2-beb43f6a8825"), 923.17m, "Haag - Goldner", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(849), "736", null },
                    { new Guid("70ac1cdd-adeb-4272-b044-9b0fcb0d0ba1"), 927.99m, "Raynor, Morissette and Marvin", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(9361), "044", null },
                    { new Guid("720e98ee-5279-46d9-84b6-8980f184eb29"), 147.15m, "McClure Inc", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(6767), "609", null },
                    { new Guid("74a1be3e-1454-4bd5-9665-e6e27c640a55"), 509.08m, "Weber - Rogahn", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(6202), "430", null },
                    { new Guid("7593222e-341d-40f4-a451-764a2c570634"), 956.83m, "Bartell - Shanahan", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(7947), "275", null },
                    { new Guid("76696114-641a-4ae6-894b-aae0daf3d664"), 73.52m, "Jast - Bednar", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(4682), "837", null },
                    { new Guid("78f6ccd7-b150-410c-9969-ff44fcaaafda"), 866.53m, "Conroy - Kihn", new DateTime(2023, 5, 11, 15, 46, 21, 780, DateTimeKind.Local).AddTicks(9258), "342", null },
                    { new Guid("7abc8737-253a-46ee-b1cf-d60dfe6b8a8d"), 297.80m, "Stracke - Rempel", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(614), "676", null },
                    { new Guid("80697f80-d6ed-4c6d-abf1-16d242d109a7"), 707.15m, "Effertz LLC", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(5223), "636", null },
                    { new Guid("80e206e1-8d17-4ad7-a1f1-8ce0372d03eb"), 525.85m, "Hoeger, Cummings and Schamberger", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(3317), "415", null },
                    { new Guid("827eaf74-a329-4ead-8b68-93915fa86e57"), 360.42m, "Labadie, VonRueden and Batz", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(4701), "460", null },
                    { new Guid("843063e4-c96d-4b2c-b12e-07faec965f93"), 423.72m, "Klocko - Morar", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(6533), "530", null },
                    { new Guid("84a40ff7-aac4-43ce-af5e-12bc3e41a0e6"), 861.25m, "Harber LLC", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(295), "887", null },
                    { new Guid("8721ef07-9a20-41c5-8e93-93406a2aab1d"), 248.68m, "Erdman - Romaguera", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(9722), "855", null },
                    { new Guid("8982ceea-042f-4c6b-ab24-48efcec1cd12"), 889.43m, "Ritchie, Koss and Schuster", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(5864), "250", null },
                    { new Guid("8a928493-f39d-465c-9bb9-633ace353e6e"), 668.70m, "Hahn - Hand", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(9127), "972", null },
                    { new Guid("8e5ed374-2f5b-4065-b8e7-22b95e3868f6"), 476.48m, "Reinger, Kris and Klein", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(7152), "488", null },
                    { new Guid("948cc5a9-3ea6-478d-b90b-6d7d5eee24d4"), 569.94m, "Gottlieb - Champlin", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(1142), "969", null },
                    { new Guid("98319de5-e39e-4a80-ba6f-054d1e92d0f0"), 629.26m, "Kris - Graham", new DateTime(2023, 5, 11, 15, 46, 21, 780, DateTimeKind.Local).AddTicks(8822), "570", null },
                    { new Guid("99c4bdf2-a566-4b48-83c9-ce5c101f9de0"), 526.73m, "Bartoletti Group", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(8836), "486", null },
                    { new Guid("9a1e833d-a712-4a9f-94cf-b2e557ae7eb4"), 287.93m, "Goodwin Inc", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(4080), "377", null },
                    { new Guid("9aae6ee8-d4b6-43ac-bd8a-7848b302e290"), 525.73m, "Altenwerth, Bartoletti and Daniel", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(5458), "240", null },
                    { new Guid("9de087af-17c9-4d5c-9406-89535fc1b3f7"), 151.58m, "Adams, Howe and Rutherford", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(3705), "933", null },
                    { new Guid("9e9acc5a-9c1d-44af-bbab-8a722d6c5aca"), 123.57m, "Raynor - Wolff", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(7093), "013", null },
                    { new Guid("a0a90ad6-eaaf-46fe-9bd0-c8c00da3ee8b"), 783.78m, "Pfannerstill, Stark and Macejkovic", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(1366), "259", null },
                    { new Guid("a94e6ac8-8b5d-473d-8990-ef33fccc4424"), 185.00m, "O'Reilly - Hyatt", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(4095), "835", null },
                    { new Guid("ac8c8b86-1d07-48f3-a35c-c736365ee2bf"), 272.50m, "Brekke - Marquardt", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(4921), "711", null },
                    { new Guid("acce1e88-640b-492c-91c9-49399a5aee32"), 513.61m, "Aufderhar, Kirlin and Marks", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(7), "837", null },
                    { new Guid("acef5f8b-48f2-40ea-9a64-2cc1f9676bcd"), 298.00m, "DuBuque, Ziemann and D'Amore", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(5309), "577", null },
                    { new Guid("ad7b544a-d687-4c40-85d9-0f2833c74542"), 511.10m, "Botsford and Sons", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(7700), "056", null },
                    { new Guid("aef73a43-d91d-4604-8d3f-85c5d7e37934"), 495.31m, "Kuhn Inc", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(3086), "042", null },
                    { new Guid("c1ca5694-e4b0-481a-8425-77033a853357"), 445.02m, "Kassulke, Green and Koch", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(3325), "504", null },
                    { new Guid("c42b5a4a-5a10-4108-bb08-4c42b9a5457b"), 446.22m, "Ernser LLC", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(7331), "838", null },
                    { new Guid("c5f9c028-a111-4e0e-8e47-0285aed730fa"), 96.62m, "McGlynn, Purdy and Kub", new DateTime(2023, 5, 11, 15, 46, 21, 780, DateTimeKind.Local).AddTicks(4861), "338", null },
                    { new Guid("c6703a80-c6ab-4420-b6b8-8d5b2623d0b8"), 16.41m, "Fritsch - Swift", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(5685), "268", null },
                    { new Guid("c83a425d-5683-4856-8274-0e8c295d3002"), 704.65m, "Hyatt, Effertz and Skiles", new DateTime(2023, 5, 11, 15, 46, 21, 783, DateTimeKind.Local).AddTicks(322), "046", null },
                    { new Guid("c9c6f8f6-ef5d-437c-8bb9-e86076463db8"), 230.33m, "Schumm, Luettgen and Fritsch", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(3726), "311", null },
                    { new Guid("ced9d0df-9332-4f07-ad68-bf652e90ca80"), 134.11m, "Hessel Group", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(1736), "266", null },
                    { new Guid("d1698989-1cba-420b-b76a-36fa82078567"), 949.47m, "Ward, Jakubowski and Johnston", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(6779), "321", null },
                    { new Guid("d1ec1e93-fc67-489e-8dfc-7351983fbe83"), 434.08m, "Brown, Dietrich and Jerde", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(2291), "934", null },
                    { new Guid("dc7e7d8d-ef8d-45d9-9510-f81e122dcc89"), 599.70m, "Brown Group", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(5070), "129", null },
                    { new Guid("ddddc2cc-e363-45c5-aeb8-43465f6a500f"), 215.71m, "Gibson Inc", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(2758), "407", null },
                    { new Guid("e5f99649-19f2-4aaf-b1ff-54414da235cb"), 359.36m, "Von, Schumm and Littel", new DateTime(2023, 5, 11, 15, 46, 21, 782, DateTimeKind.Local).AddTicks(4330), "348", null },
                    { new Guid("e7bc3119-81bf-43c3-84ad-c099ae282ea3"), 589.38m, "Cronin - Bartell", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(7582), "470", null },
                    { new Guid("f76e55fa-0b70-4d4f-85d5-e8ea93200443"), 304.15m, "Waters - Runolfsson", new DateTime(2023, 5, 11, 15, 46, 21, 781, DateTimeKind.Local).AddTicks(7840), "076", null }
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "ID", "CreatedDateTime", "ExpirationDate", "Limit", "MoneyOwed", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("012c58dd-b20e-41f9-b946-56528b534098"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8132), new DateTime(2023, 8, 14, 10, 57, 41, 298, DateTimeKind.Local).AddTicks(1172), 29.14m, 464.55m, null },
                    { new Guid("038bb6c1-90ff-4df1-955d-b880602eb3e7"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 11, 11, 16, 43, 20, 239, DateTimeKind.Local).AddTicks(2687), 394.92m, 590.58m, null },
                    { new Guid("08025c83-c021-44a8-9f56-b6ab21e7f54a"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9250), new DateTime(2023, 9, 13, 1, 47, 17, 555, DateTimeKind.Local).AddTicks(3348), 168.83m, 715.38m, null },
                    { new Guid("09efe131-bbf4-411d-b6f7-13c5be07f2ef"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8927), new DateTime(2024, 1, 1, 9, 20, 39, 379, DateTimeKind.Local).AddTicks(2979), 707.91m, 818.55m, null },
                    { new Guid("0b09bb1f-036c-4b30-b9fe-392a4f1d8403"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 2, 10, 20, 29, 24, 578, DateTimeKind.Local).AddTicks(1510), 155.53m, 118.91m, null },
                    { new Guid("104cfec7-478c-433f-b151-92de678d582f"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8276), new DateTime(2023, 6, 7, 12, 3, 2, 989, DateTimeKind.Local).AddTicks(3187), 396.42m, 998.62m, null },
                    { new Guid("10c38e3a-21fe-4446-930c-297e5bea2c94"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8969), new DateTime(2024, 3, 27, 3, 36, 36, 938, DateTimeKind.Local).AddTicks(2997), 227.40m, 407.58m, null },
                    { new Guid("198aa3b2-20a5-4e94-b91b-260550a91b1a"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9161), new DateTime(2023, 12, 5, 2, 4, 19, 396, DateTimeKind.Local).AddTicks(9648), 170.25m, 341.30m, null },
                    { new Guid("1bba3ab4-6cfc-4b1e-bdcf-8299b90b9ce8"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9207), new DateTime(2023, 6, 19, 13, 54, 33, 206, DateTimeKind.Local).AddTicks(2371), 703.42m, 314.29m, null },
                    { new Guid("1bded76c-00d1-4d9c-969d-e256dc20ee3d"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9060), new DateTime(2023, 5, 27, 15, 36, 58, 100, DateTimeKind.Local).AddTicks(5072), 338.94m, 914.39m, null },
                    { new Guid("1dd1d99f-8ac5-49d3-aa83-2bdfa5676435"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 6, 6, 10, 10, 57, 54, DateTimeKind.Local).AddTicks(3286), 339.32m, 484.69m, null },
                    { new Guid("274314a0-6649-4d60-a64e-b300bd141c74"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8412), new DateTime(2023, 9, 1, 16, 11, 50, 225, DateTimeKind.Local).AddTicks(4814), 709.02m, 251.79m, null },
                    { new Guid("2a0c9262-c3ab-4121-8f7f-d4fdfab51c43"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 9, 12, 21, 30, 39, 998, DateTimeKind.Local).AddTicks(8475), 475.98m, 826.91m, null },
                    { new Guid("2d73bb95-a5d5-421a-9a1d-e1e2c16719d4"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 5, 6, 9, 40, 31, 556, DateTimeKind.Local).AddTicks(5664), 116.64m, 254.30m, null },
                    { new Guid("31e3af77-5bd0-4205-8651-0314a7a0ffd2"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 9, 26, 11, 4, 57, 444, DateTimeKind.Local).AddTicks(6130), 533.25m, 491.68m, null },
                    { new Guid("3a60a2d4-9ebc-40e7-91f8-a6d1d769f83d"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 2, 4, 4, 37, 48, 594, DateTimeKind.Local).AddTicks(1298), 599.11m, 292.23m, null },
                    { new Guid("3a91f79e-d889-4d95-8c99-345be9f1a1d1"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 8, 31, 4, 28, 39, 869, DateTimeKind.Local).AddTicks(1985), 927.74m, 270.67m, null },
                    { new Guid("3a9202ac-129d-4c41-93c5-802698805f69"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 4, 27, 2, 55, 55, 870, DateTimeKind.Local).AddTicks(218), 448.31m, 22.98m, null },
                    { new Guid("3f028c30-0174-4d45-90f9-33fb26850459"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 2, 5, 15, 14, 45, 143, DateTimeKind.Local).AddTicks(5209), 301.49m, 542.32m, null },
                    { new Guid("3f42e90e-772c-44af-bc3a-65d350b63755"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 3, 11, 11, 59, 12, 627, DateTimeKind.Local).AddTicks(9072), 920.50m, 620.27m, null },
                    { new Guid("4a10d10f-b5f7-47d4-8e34-dd4d77fd1914"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8111), new DateTime(2024, 5, 4, 1, 6, 52, 594, DateTimeKind.Local).AddTicks(9935), 140.54m, 876.87m, null },
                    { new Guid("4c100567-0337-45ac-a0df-3597461bfb4d"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9547), new DateTime(2024, 3, 10, 23, 29, 32, 267, DateTimeKind.Local).AddTicks(4685), 666.57m, 485.37m, null },
                    { new Guid("55f0be7f-3ac8-4376-b03a-9ecc57827a14"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 8, 21, 3, 31, 29, 481, DateTimeKind.Local).AddTicks(7430), 258.05m, 133.61m, null },
                    { new Guid("5d88d472-3fef-4492-9ed1-33b9229afb18"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 8, 17, 19, 21, 20, 427, DateTimeKind.Local).AddTicks(981), 660.60m, 328.27m, null },
                    { new Guid("5f2519f5-cb88-444b-ae25-7aaf1b04e96b"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9654), new DateTime(2024, 4, 9, 14, 40, 12, 721, DateTimeKind.Local).AddTicks(9437), 196.93m, 251.37m, null },
                    { new Guid("6b6487ee-1537-4f81-820f-0703876795f0"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9614), new DateTime(2023, 12, 7, 11, 4, 16, 220, DateTimeKind.Local).AddTicks(5891), 955.85m, 379.73m, null },
                    { new Guid("6fc5d02e-6e94-4e42-ae6f-7d6fdcf1ac93"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8749), new DateTime(2024, 2, 19, 14, 46, 37, 259, DateTimeKind.Local).AddTicks(5420), 953.79m, 808.94m, null },
                    { new Guid("703605d7-abb7-4609-88b8-eee2bade798b"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8433), new DateTime(2023, 6, 12, 2, 31, 21, 146, DateTimeKind.Local).AddTicks(4984), 819.33m, 424.72m, null },
                    { new Guid("7b80a425-d303-41d9-b739-d372ce57e540"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8359), new DateTime(2023, 7, 13, 5, 12, 35, 484, DateTimeKind.Local).AddTicks(477), 680.60m, 108.98m, null },
                    { new Guid("7c222fde-957d-4712-ae20-96be739cc5ed"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8771), new DateTime(2023, 7, 14, 6, 45, 38, 924, DateTimeKind.Local).AddTicks(7209), 846.33m, 787.27m, null },
                    { new Guid("85e85c4c-b856-43c8-a17f-372d355aaa80"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 3, 27, 7, 18, 4, 829, DateTimeKind.Local).AddTicks(5931), 319.53m, 821.65m, null },
                    { new Guid("8a25cc6c-5f91-4455-99dd-e50b852d9a75"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8907), new DateTime(2023, 9, 13, 17, 34, 23, 25, DateTimeKind.Local).AddTicks(7574), 439.90m, 494.40m, null },
                    { new Guid("8c086135-7382-46d5-91fc-5f858a05bd19"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8316), new DateTime(2023, 12, 18, 14, 57, 31, 571, DateTimeKind.Local).AddTicks(7806), 777.75m, 4.97m, null },
                    { new Guid("8fd881e0-16ad-4a33-b85b-7f69d89ab82b"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9081), new DateTime(2024, 1, 2, 11, 33, 41, 681, DateTimeKind.Local).AddTicks(6041), 148.56m, 906.26m, null },
                    { new Guid("90e64a78-5f1e-4c71-9207-c56e979e6333"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 6, 24, 18, 43, 47, 687, DateTimeKind.Local).AddTicks(334), 559.58m, 240.21m, null },
                    { new Guid("9315c04b-b28f-44f5-bce7-29073c87ccd1"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8089), new DateTime(2024, 3, 9, 2, 12, 56, 830, DateTimeKind.Local).AddTicks(5853), 153.29m, 820.07m, null },
                    { new Guid("9a09e349-c8c9-457f-a2c2-4add74bacf70"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9016), new DateTime(2023, 7, 30, 17, 1, 47, 938, DateTimeKind.Local).AddTicks(1010), 739.00m, 52.77m, null },
                    { new Guid("9ecd38ee-2c36-4905-b4df-2e1ea2292247"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 11, 20, 18, 37, 22, 203, DateTimeKind.Local).AddTicks(111), 678.74m, 790.28m, null },
                    { new Guid("9f38607a-faa5-4b92-ae10-00d511c20067"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 1, 13, 18, 22, 27, 737, DateTimeKind.Local).AddTicks(2274), 986.48m, 218.37m, null },
                    { new Guid("a13a9653-4e61-472e-bb0a-935b259268f0"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 8, 4, 13, 0, 53, 649, DateTimeKind.Local).AddTicks(9261), 141.51m, 134.51m, null },
                    { new Guid("a3c319ed-f30e-492d-b3f8-decaa144b3d5"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9314), new DateTime(2023, 9, 3, 5, 12, 5, 764, DateTimeKind.Local).AddTicks(9644), 473.63m, 231.92m, null },
                    { new Guid("a7fc0aa0-1bf6-468b-a192-177531de128b"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 10, 16, 12, 27, 19, 106, DateTimeKind.Local).AddTicks(1131), 945.19m, 972.24m, null },
                    { new Guid("a830d091-5893-4c1a-8b8f-7d52746423da"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 4, 26, 14, 40, 10, 132, DateTimeKind.Local).AddTicks(7124), 674.41m, 291.12m, null },
                    { new Guid("a8f79f65-eef5-4b54-b07a-1fe9ee9dac81"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 10, 13, 5, 27, 40, 237, DateTimeKind.Local).AddTicks(1942), 717.52m, 379.14m, null },
                    { new Guid("a9377083-cd32-4fab-8025-43236d49c0e1"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8296), new DateTime(2023, 6, 2, 23, 55, 31, 360, DateTimeKind.Local).AddTicks(5192), 377.12m, 602.14m, null },
                    { new Guid("aad2b2eb-19fa-4c64-b952-d4ce8827a9cc"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 11, 2, 19, 57, 26, 277, DateTimeKind.Local).AddTicks(8420), 81.82m, 663.20m, null },
                    { new Guid("ad5dda94-c78d-4410-abd0-c88129aaafd5"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8949), new DateTime(2024, 2, 4, 6, 6, 18, 863, DateTimeKind.Local).AddTicks(1784), 362.05m, 343.72m, null },
                    { new Guid("b110f9fd-a5ae-4d13-8398-2fe01dcec69a"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 10, 3, 18, 26, 57, 515, DateTimeKind.Local).AddTicks(7152), 719.51m, 553.05m, null },
                    { new Guid("b17c80bd-a271-4f00-98a2-3c2391815eef"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 10, 17, 22, 37, 36, 911, DateTimeKind.Local).AddTicks(5226), 297.67m, 734.50m, null },
                    { new Guid("b182fb3b-b0fa-436b-9cf4-7163fee4a4d1"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9359), new DateTime(2023, 7, 9, 15, 54, 40, 652, DateTimeKind.Local).AddTicks(4760), 592.85m, 519.46m, null },
                    { new Guid("b25f09da-8381-45e1-9b9f-8a0d5f244850"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(4021), new DateTime(2023, 8, 6, 14, 33, 12, 427, DateTimeKind.Local).AddTicks(3559), 314.21m, 162.61m, null },
                    { new Guid("b761d79d-373f-45c9-86d4-7a4fa3c2d722"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 6, 7, 19, 2, 7, 546, DateTimeKind.Local).AddTicks(3197), 459.08m, 572.83m, null },
                    { new Guid("bcb43f69-be34-426a-bf20-2dae01064c3a"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9101), new DateTime(2024, 5, 6, 18, 51, 48, 772, DateTimeKind.Local).AddTicks(190), 494.68m, 292.71m, null },
                    { new Guid("be7dff11-3595-4df6-9376-eb55109729d0"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9290), new DateTime(2023, 5, 14, 1, 14, 39, 703, DateTimeKind.Local).AddTicks(68), 181.96m, 490.98m, null },
                    { new Guid("c02c417f-7367-44d7-b05f-cda9659d5bd4"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 7, 4, 0, 9, 8, 130, DateTimeKind.Local).AddTicks(2511), 660.21m, 471.42m, null },
                    { new Guid("c292f624-03eb-46b9-8b06-022c70a71921"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9228), new DateTime(2023, 11, 1, 21, 38, 18, 795, DateTimeKind.Local).AddTicks(3647), 199.99m, 473.26m, null },
                    { new Guid("caeab430-35c3-47f6-bfc4-602db8f32413"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 3, 15, 6, 4, 38, 458, DateTimeKind.Local).AddTicks(2777), 984.79m, 282.15m, null },
                    { new Guid("d6b6aa20-b9a2-4ae8-ac8e-8b11458a1abc"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8817), new DateTime(2024, 4, 8, 12, 2, 1, 555, DateTimeKind.Local).AddTicks(7323), 695.89m, 914.60m, null },
                    { new Guid("d881a309-bfe6-43a7-b10a-0a81b43a079f"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 8, 12, 20, 35, 13, 731, DateTimeKind.Local).AddTicks(8431), 105.08m, 637.95m, null },
                    { new Guid("ddd9d84e-5bb8-4512-b625-c5d4a06ea948"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 9, 5, 23, 47, 16, 640, DateTimeKind.Local).AddTicks(5143), 781.25m, 495.12m, null },
                    { new Guid("df0725ef-a8f7-4f0e-b1d5-9222158db29d"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9593), new DateTime(2023, 8, 6, 12, 54, 44, 391, DateTimeKind.Local).AddTicks(7626), 253.36m, 727.95m, null },
                    { new Guid("e32a5d9c-3bac-47c5-8890-cd0c73aff7fa"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8864), new DateTime(2023, 7, 21, 21, 22, 23, 603, DateTimeKind.Local).AddTicks(4607), 92.37m, 951.39m, null },
                    { new Guid("e580f9f4-7c7d-45f7-bd9b-a7662c571268"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8615), new DateTime(2023, 8, 11, 1, 23, 5, 952, DateTimeKind.Local).AddTicks(4505), 868.56m, 365.43m, null },
                    { new Guid("e7eb8521-87ec-4f80-ba0d-60f3de197b3f"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 4, 8, 14, 37, 41, 744, DateTimeKind.Local).AddTicks(1514), 687.98m, 29.00m, null },
                    { new Guid("e807f62f-5cb0-4cff-afff-0f5194cfbd1c"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9185), new DateTime(2023, 9, 18, 19, 42, 49, 974, DateTimeKind.Local).AddTicks(6627), 507.55m, 141.78m, null },
                    { new Guid("eb088506-a028-4d69-8a55-c79bcaf1852f"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 2, 3, 9, 39, 48, 303, DateTimeKind.Local).AddTicks(4821), 584.54m, 741.50m, null },
                    { new Guid("ee7a7bee-1292-4431-9666-5c8468c526ae"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 12, 16, 12, 40, 3, 309, DateTimeKind.Local).AddTicks(9190), 426.67m, 883.02m, null },
                    { new Guid("f0d1c7d2-9e1f-4fa5-ad2d-e917432ecc63"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 4, 18, 0, 26, 3, 875, DateTimeKind.Local).AddTicks(5050), 98.44m, 881.15m, null },
                    { new Guid("f0d6ff2e-7f36-4d4b-9397-4e365507b35a"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8192), new DateTime(2023, 11, 3, 16, 11, 24, 717, DateTimeKind.Local).AddTicks(1626), 729.11m, 386.74m, null },
                    { new Guid("f4383a94-9162-4f41-9849-5f8147bb1fb1"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(8660), new DateTime(2023, 11, 23, 14, 2, 36, 154, DateTimeKind.Local).AddTicks(2481), 136.73m, 942.94m, null },
                    { new Guid("f53bf0fd-041c-482f-be9f-dbf062fddc00"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9334), new DateTime(2023, 11, 10, 13, 15, 5, 130, DateTimeKind.Local).AddTicks(4999), 350.67m, 332.73m, null },
                    { new Guid("f6286538-7d0d-4aed-887b-109d4e9fa35f"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9763), new DateTime(2024, 2, 19, 17, 35, 33, 861, DateTimeKind.Local).AddTicks(7828), 390.57m, 57.58m, null },
                    { new Guid("f676fb1c-fbaa-404d-980d-a38ac73f038e"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 5, 27, 8, 46, 15, 816, DateTimeKind.Local).AddTicks(3610), 178.65m, 190.41m, null },
                    { new Guid("fa44abad-5aef-47aa-8560-5e652fdbb60b"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 4, 9, 14, 51, 20, 418, DateTimeKind.Local).AddTicks(4539), 536.41m, 953.63m, null },
                    { new Guid("fd5bd548-d7e7-4331-91d8-bb84b3c958f4"), new DateTime(2023, 5, 11, 15, 46, 21, 774, DateTimeKind.Local).AddTicks(9271), new DateTime(2024, 1, 15, 3, 19, 29, 642, DateTimeKind.Local).AddTicks(8545), 532.46m, 419.39m, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDateTime", "Email", "FirstName", "LastName", "Password", "UpdateDateTime" },
                values: new object[,]
                {
                    { new Guid("071e7c9b-d059-4a3e-95e4-395709477ef4"), new DateTime(2023, 5, 11, 15, 46, 21, 768, DateTimeKind.Local).AddTicks(6148), "Kelley.Collier59@gmail.com", "Kelley", "Collier", "epGvHab1T2", null },
                    { new Guid("2e66da9d-5bc7-43bb-b450-737a13019b30"), new DateTime(2023, 5, 11, 15, 46, 21, 766, DateTimeKind.Local).AddTicks(6292), "Freddie_Blanda74@gmail.com", "Freddie", "Blanda", "RAfSr7Mrdq", null },
                    { new Guid("322c1109-a5c4-401b-9836-71fb28371ca8"), new DateTime(2023, 5, 11, 15, 46, 21, 767, DateTimeKind.Local).AddTicks(436), "Vera_Herman18@hotmail.com", "Vera", "Herman", "djKTypFynU", null },
                    { new Guid("3aa3d068-8f55-4de7-9207-2f58a7cc7acf"), new DateTime(2023, 5, 11, 15, 46, 21, 762, DateTimeKind.Local).AddTicks(3654), "Noel_Kuhn48@hotmail.com", "Noel", "Kuhn", "FtkGJ6grc2", null },
                    { new Guid("3ba36ee2-03d8-4f9d-a33e-eca0fec8304b"), new DateTime(2023, 5, 11, 15, 46, 21, 766, DateTimeKind.Local).AddTicks(1922), "Jo_Kshlerin@gmail.com", "Jo", "Kshlerin", "Lcbqn6oltw", null },
                    { new Guid("3db6bff2-8438-42ed-b14d-a2dc7eb87f9e"), new DateTime(2023, 5, 11, 15, 46, 21, 764, DateTimeKind.Local).AddTicks(5969), "Julie_Wiza8@hotmail.com", "Julie", "Wiza", "_lpX0552nX", null },
                    { new Guid("47b001aa-a865-4ba2-889d-f08b50366816"), new DateTime(2023, 5, 11, 15, 46, 21, 764, DateTimeKind.Local).AddTicks(1727), "Dominic_Von@gmail.com", "Dominic", "Von", "13GydC7gFq", null },
                    { new Guid("5278ce7e-11d4-487c-b6f1-389d31643c0f"), new DateTime(2023, 5, 11, 15, 46, 21, 763, DateTimeKind.Local).AddTicks(7338), "Isabel91@hotmail.com", "Isabel", "Lind", "OmZ0urBklq", null },
                    { new Guid("55db46d7-caa2-413d-a663-5d555ade7123"), new DateTime(2023, 5, 11, 15, 46, 21, 764, DateTimeKind.Local).AddTicks(3826), "Travis22@yahoo.com", "Travis", "Kreiger", "hNfflAtrbm", null },
                    { new Guid("636c929a-e7d7-461f-9c90-d011cd1918e2"), new DateTime(2023, 5, 11, 15, 46, 21, 767, DateTimeKind.Local).AddTicks(5013), "Nichole36@yahoo.com", "Nichole", "McGlynn", "SuOEkiU2NV", null },
                    { new Guid("6fce17c2-a2ba-45a7-9f06-d26c2f49bab0"), new DateTime(2023, 5, 11, 15, 46, 21, 767, DateTimeKind.Local).AddTicks(8837), "Vickie.Hahn@gmail.com", "Vickie", "Hahn", "ObizeRdbbX", null },
                    { new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a"), new DateTime(2023, 5, 11, 15, 46, 21, 765, DateTimeKind.Local).AddTicks(9820), "Elmer78@gmail.com", "Elmer", "Haley", "Rxjm8eb3O3", null },
                    { new Guid("80b5ac0a-25e6-4fc7-880e-76a50b285dd3"), new DateTime(2023, 5, 11, 15, 46, 21, 762, DateTimeKind.Local).AddTicks(9152), "Luis_Wolf@yahoo.com", "Luis", "Wolf", "QptspBb0D2", null },
                    { new Guid("87a8290b-c990-45f3-be03-4faad1c206c9"), new DateTime(2023, 5, 11, 15, 46, 21, 765, DateTimeKind.Local).AddTicks(684), "Nadine_Goodwin@hotmail.com", "Nadine", "Goodwin", "oQxd0_ACNL", null },
                    { new Guid("94729f88-8dff-4713-8dc0-b82601274451"), new DateTime(2023, 5, 11, 15, 46, 21, 766, DateTimeKind.Local).AddTicks(8367), "Dale96@hotmail.com", "Dale", "Kulas", "9KY2bs9r6T", null },
                    { new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53"), new DateTime(2023, 5, 11, 15, 46, 21, 765, DateTimeKind.Local).AddTicks(5168), "Joseph.Wilkinson46@yahoo.com", "Joseph", "Wilkinson", "g0feFKp8Jy", null },
                    { new Guid("a2967b56-bc29-4eb4-b152-cc3de6edfc38"), new DateTime(2023, 5, 11, 15, 46, 21, 768, DateTimeKind.Local).AddTicks(2799), "Rolando_Fay29@yahoo.com", "Rolando", "Fay", "H3LTtt9YB_", null },
                    { new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9"), new DateTime(2023, 5, 11, 15, 46, 21, 765, DateTimeKind.Local).AddTicks(7596), "Tomas48@hotmail.com", "Tomas", "Fisher", "sKtzmscRfS", null },
                    { new Guid("ab5cea50-762d-41cd-8e14-d2beac94f682"), new DateTime(2023, 5, 11, 15, 46, 21, 765, DateTimeKind.Local).AddTicks(2898), "Angel_Nitzsche@hotmail.com", "Angel", "Nitzsche", "ezXQdDIzJv", null },
                    { new Guid("bd4d048b-e693-4c16-9db3-6c5d416ab7bc"), new DateTime(2023, 5, 11, 15, 46, 21, 764, DateTimeKind.Local).AddTicks(8581), "Julius.Ferry13@hotmail.com", "Julius", "Ferry", "swESDBeyKo", null },
                    { new Guid("c062d7a6-84c5-4369-8d3c-e35cbcde7160"), new DateTime(2023, 5, 11, 15, 46, 21, 763, DateTimeKind.Local).AddTicks(2847), "Dale71@hotmail.com", "Dale", "Kohler", "8SRVN_bbM6", null },
                    { new Guid("d92cc4fb-ef95-4edc-8fc1-014a1a33269e"), new DateTime(2023, 5, 11, 15, 46, 21, 767, DateTimeKind.Local).AddTicks(2794), "Kristine_Bradtke4@hotmail.com", "Kristine", "Bradtke", "bVvzgp_zOE", null },
                    { new Guid("e1d9373c-eaf9-4872-952b-3338b7d1c616"), new DateTime(2023, 5, 11, 15, 46, 21, 763, DateTimeKind.Local).AddTicks(9697), "Opal.Wyman55@yahoo.com", "Opal", "Wyman", "tQKKel2TKH", null },
                    { new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35"), new DateTime(2023, 5, 11, 15, 46, 21, 766, DateTimeKind.Local).AddTicks(4353), "Walter_Hoeger87@hotmail.com", "Walter", "Hoeger", "KPSEfJqY2Z", null },
                    { new Guid("faba7073-9f80-4e89-a09b-046bc537e1ea"), new DateTime(2023, 5, 11, 15, 46, 21, 763, DateTimeKind.Local).AddTicks(5252), "Jeremy43@yahoo.com", "Jeremy", "Nicolas", "Rdikg0ODsq", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "ID", "BankAccountId", "CreatedDateTime", "CreditCardId", "Type", "UpdateDateTime", "UserId" },
                values: new object[,]
                {
                    { new Guid("07e9be41-3506-42d1-8488-a7c58cbffbad"), new Guid("c9c6f8f6-ef5d-437c-8bb9-e86076463db8"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2813), new Guid("bcb43f69-be34-426a-bf20-2dae01064c3a"), 1, null, new Guid("55db46d7-caa2-413d-a663-5d555ade7123") },
                    { new Guid("0851e838-f2ed-4699-8050-abf5a62d4234"), new Guid("e5f99649-19f2-4aaf-b1ff-54414da235cb"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2852), new Guid("f0d1c7d2-9e1f-4fa5-ad2d-e917432ecc63"), 0, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("0b00d0b3-9b8e-42f4-abca-09ef68f43ad4"), new Guid("ced9d0df-9332-4f07-ad68-bf652e90ca80"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2695), new Guid("10c38e3a-21fe-4446-930c-297e5bea2c94"), 0, null, new Guid("a2967b56-bc29-4eb4-b152-cc3de6edfc38") },
                    { new Guid("0b52899c-90c0-464c-bf12-8b02e6e090b8"), new Guid("24f911ff-4535-40ab-82fa-f6b2c1313b23"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2953), new Guid("08025c83-c021-44a8-9f56-b6ab21e7f54a"), 1, null, new Guid("3db6bff2-8438-42ed-b14d-a2dc7eb87f9e") },
                    { new Guid("0cfc76fa-fe31-4bc5-8386-6a774b0b312e"), new Guid("57750a84-1b63-401d-81e7-b23b08373d86"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3512), new Guid("f6286538-7d0d-4aed-887b-109d4e9fa35f"), 0, null, new Guid("5278ce7e-11d4-487c-b6f1-389d31643c0f") },
                    { new Guid("1004a534-03e2-4ecd-9036-9d1fa387e8fa"), new Guid("a94e6ac8-8b5d-473d-8990-ef33fccc4424"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2830), new Guid("55f0be7f-3ac8-4376-b03a-9ecc57827a14"), 1, null, new Guid("e1d9373c-eaf9-4872-952b-3338b7d1c616") },
                    { new Guid("12a50e96-f923-4e0d-a8ea-dca6b42cc57b"), new Guid("8721ef07-9a20-41c5-8e93-93406a2aab1d"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3357), new Guid("df0725ef-a8f7-4f0e-b1d5-9222158db29d"), 1, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("12de1398-0989-4a64-a057-6e9aed737c51"), new Guid("8982ceea-042f-4c6b-ab24-48efcec1cd12"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2197), new Guid("ee7a7bee-1292-4431-9666-5c8468c526ae"), 1, null, new Guid("5278ce7e-11d4-487c-b6f1-389d31643c0f") },
                    { new Guid("2523f76c-af59-4a8e-8e7b-41f6661672a5"), new Guid("acce1e88-640b-492c-91c9-49399a5aee32"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3375), new Guid("6b6487ee-1537-4f81-820f-0703876795f0"), 1, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("2872d33b-2b91-4bac-9713-3fa2dda943e0"), new Guid("5d5f90d0-c58a-491d-9ccf-6e4c7eef0e39"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3432), new Guid("9f38607a-faa5-4b92-ae10-00d511c20067"), 0, null, new Guid("2e66da9d-5bc7-43bb-b450-737a13019b30") },
                    { new Guid("29369ed1-5c9e-4c0f-9132-f8c70a38c10a"), new Guid("8a928493-f39d-465c-9bb9-633ace353e6e"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3318), new Guid("4c100567-0337-45ac-a0df-3597461bfb4d"), 1, null, new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9") },
                    { new Guid("2af681e5-0de3-4b1e-818e-21f88b0b4eef"), new Guid("78f6ccd7-b150-410c-9969-ff44fcaaafda"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1783), new Guid("90e64a78-5f1e-4c71-9207-c56e979e6333"), 1, null, new Guid("ab5cea50-762d-41cd-8e14-d2beac94f682") },
                    { new Guid("2d0f5b29-17ba-472b-adc5-c9613a33c9c1"), new Guid("d1698989-1cba-420b-b76a-36fa82078567"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2260), new Guid("3a60a2d4-9ebc-40e7-91f8-a6d1d769f83d"), 1, null, new Guid("3ba36ee2-03d8-4f9d-a33e-eca0fec8304b") },
                    { new Guid("3036bff8-9dc7-435c-aa0e-2ae33d2af8b0"), new Guid("267eeddc-d642-41a3-b734-cfb06ae660de"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2755), new Guid("3a91f79e-d889-4d95-8c99-345be9f1a1d1"), 1, null, new Guid("3db6bff2-8438-42ed-b14d-a2dc7eb87f9e") },
                    { new Guid("33830c54-638c-463d-bfd2-81d035a84b9d"), new Guid("e7bc3119-81bf-43c3-84ad-c099ae282ea3"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2301), new Guid("a8f79f65-eef5-4b54-b07a-1fe9ee9dac81"), 0, null, new Guid("6fce17c2-a2ba-45a7-9f06-d26c2f49bab0") },
                    { new Guid("35f1a593-0e37-4488-ac03-714649a4e574"), new Guid("720e98ee-5279-46d9-84b6-8980f184eb29"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3016), new Guid("a3c319ed-f30e-492d-b3f8-decaa144b3d5"), 1, null, new Guid("3ba36ee2-03d8-4f9d-a33e-eca0fec8304b") },
                    { new Guid("36c68f9e-625e-4e7e-9873-8832c9903a6c"), new Guid("449a74c5-70af-40ac-8e85-a5cf70e63040"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1911), new Guid("a13a9653-4e61-472e-bb0a-935b259268f0"), 1, null, new Guid("d92cc4fb-ef95-4edc-8fc1-014a1a33269e") },
                    { new Guid("381d10b9-320a-45c4-b5b5-ae91cc2b6fd6"), new Guid("51992e7c-ca0d-46bf-bdb6-a50849ddde53"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3530), new Guid("85e85c4c-b856-43c8-a17f-372d355aaa80"), 0, null, new Guid("55db46d7-caa2-413d-a663-5d555ade7123") },
                    { new Guid("428248c8-7fa3-4be4-a434-7155523388fd"), new Guid("dc7e7d8d-ef8d-45d9-9510-f81e122dcc89"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2899), new Guid("e807f62f-5cb0-4cff-afff-0f5194cfbd1c"), 1, null, new Guid("636c929a-e7d7-461f-9c90-d011cd1918e2") },
                    { new Guid("43e75d56-4b8d-4a35-b875-f6cc9e223870"), new Guid("6a994b72-9ca7-403e-8e0e-d63fb36df201"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1807), new Guid("9315c04b-b28f-44f5-bce7-29073c87ccd1"), 1, null, new Guid("071e7c9b-d059-4a3e-95e4-395709477ef4") },
                    { new Guid("4431408a-8469-4f25-9d01-9c9be4432dba"), new Guid("99c4bdf2-a566-4b48-83c9-ce5c101f9de0"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3295), new Guid("3f028c30-0174-4d45-90f9-33fb26850459"), 1, null, new Guid("47b001aa-a865-4ba2-889d-f08b50366816") },
                    { new Guid("4a037ac6-30a6-4921-833f-39ede62371fd"), new Guid("367eb2a2-f9fa-453f-9611-ec6284f96cf7"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3474), new Guid("fa44abad-5aef-47aa-8560-5e652fdbb60b"), 0, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("5428a392-f8d3-4f09-be33-9b9be0bb380f"), new Guid("0f22d77f-025e-4438-ac79-6f79c5180ff6"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2015), new Guid("104cfec7-478c-433f-b151-92de678d582f"), 0, null, new Guid("faba7073-9f80-4e89-a09b-046bc537e1ea") },
                    { new Guid("55fd835a-9aa8-43c4-81a4-8e20cf4f963d"), new Guid("76696114-641a-4ae6-894b-aae0daf3d664"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2117), new Guid("a7fc0aa0-1bf6-468b-a192-177531de128b"), 0, null, new Guid("5278ce7e-11d4-487c-b6f1-389d31643c0f") },
                    { new Guid("57c1eb6a-f08c-4494-922d-a7097690f217"), new Guid("f76e55fa-0b70-4d4f-85d5-e8ea93200443"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2319), new Guid("b110f9fd-a5ae-4d13-8398-2fe01dcec69a"), 0, null, new Guid("5278ce7e-11d4-487c-b6f1-389d31643c0f") },
                    { new Guid("584ea21e-5745-419f-9cac-4ed13aea3757"), new Guid("5666302d-9aef-4abe-bee0-903133c84428"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2358), new Guid("6fc5d02e-6e94-4e42-ae6f-7d6fdcf1ac93"), 0, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("58d311e7-617b-459b-a837-462fe56d861b"), new Guid("56148dd8-1f62-4d20-b927-11406c44f133"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1853), new Guid("012c58dd-b20e-41f9-b946-56528b534098"), 1, null, new Guid("2e66da9d-5bc7-43bb-b450-737a13019b30") },
                    { new Guid("6b525f7a-e9b4-4134-8ebf-33096886c8ad"), new Guid("843063e4-c96d-4b2c-b12e-07faec965f93"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2988), new Guid("be7dff11-3595-4df6-9376-eb55109729d0"), 1, null, new Guid("a2967b56-bc29-4eb4-b152-cc3de6edfc38") },
                    { new Guid("6e5da01a-fb26-46b7-bb2e-a32eb7aaa9fa"), new Guid("24713288-8319-46bf-b8c8-2141c3ff51d9"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2216), new Guid("c02c417f-7367-44d7-b05f-cda9659d5bd4"), 1, null, new Guid("c062d7a6-84c5-4369-8d3c-e35cbcde7160") },
                    { new Guid("7083c3c4-0a60-49c4-a780-7a3920bc1dad"), new Guid("28175114-f33d-4987-b7b1-ae8b7f029737"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3493), new Guid("aad2b2eb-19fa-4c64-b952-d4ce8827a9cc"), 0, null, new Guid("6fce17c2-a2ba-45a7-9f06-d26c2f49bab0") },
                    { new Guid("76bd3192-6dd0-48e9-a32a-658c59202d44"), new Guid("aef73a43-d91d-4604-8d3f-85c5d7e37934"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2774), new Guid("1bded76c-00d1-4d9c-969d-e256dc20ee3d"), 1, null, new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53") },
                    { new Guid("7703ad87-13af-42c6-8790-7b31d9fb43da"), new Guid("ddddc2cc-e363-45c5-aeb8-43465f6a500f"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1995), new Guid("038bb6c1-90ff-4df1-955d-b880602eb3e7"), 0, null, new Guid("87a8290b-c990-45f3-be03-4faad1c206c9") },
                    { new Guid("77eab90a-8f90-4f7e-91ad-f86ae764fd31"), new Guid("acef5f8b-48f2-40ea-9a64-2cc1f9676bcd"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2917), new Guid("1bba3ab4-6cfc-4b1e-bdcf-8299b90b9ce8"), 1, null, new Guid("55db46d7-caa2-413d-a663-5d555ade7123") },
                    { new Guid("79750cf5-3384-42ac-babd-6461804816de"), new Guid("9a1e833d-a712-4a9f-94cf-b2e557ae7eb4"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2078), new Guid("0b09bb1f-036c-4b30-b9fe-392a4f1d8403"), 1, null, new Guid("3db6bff2-8438-42ed-b14d-a2dc7eb87f9e") },
                    { new Guid("7c8b57ad-e754-4079-8bb9-a80943ad402c"), new Guid("ad7b544a-d687-4c40-85d9-0f2833c74542"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3075), new Guid("b17c80bd-a271-4f00-98a2-3c2391815eef"), 1, null, new Guid("3aa3d068-8f55-4de7-9207-2f58a7cc7acf") },
                    { new Guid("8b0bb173-dec3-41da-b978-b8994aabfb1f"), new Guid("d1ec1e93-fc67-489e-8dfc-7351983fbe83"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1976), new Guid("3a9202ac-129d-4c41-93c5-802698805f69"), 1, null, new Guid("94729f88-8dff-4713-8dc0-b82601274451") },
                    { new Guid("924f1554-14c2-4f81-923e-52767f1ae3a2"), new Guid("0004daeb-eb7a-44f4-aae6-c67bc5f80f62"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2339), new Guid("1dd1d99f-8ac5-49d3-aa83-2bdfa5676435"), 1, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("942eeae8-9923-4844-a1ac-42f2fac58c30"), new Guid("948cc5a9-3ea6-478d-b90b-6d7d5eee24d4"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2650), new Guid("09efe131-bbf4-411d-b6f7-13c5be07f2ef"), 0, null, new Guid("80b5ac0a-25e6-4fc7-880e-76a50b285dd3") },
                    { new Guid("952c35db-ff6b-4f14-8940-749865ca63ae"), new Guid("9de087af-17c9-4d5c-9406-89535fc1b3f7"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2054), new Guid("8c086135-7382-46d5-91fc-5f858a05bd19"), 1, null, new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53") },
                    { new Guid("979f1741-9bc2-426a-b720-c2fdc662ae33"), new Guid("6eee4519-4f2d-4b3e-9ce2-beb43f6a8825"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2631), new Guid("8a25cc6c-5f91-4455-99dd-e50b852d9a75"), 1, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("98bd7fea-56e3-4c24-b9b2-e37c9ef45923"), new Guid("55ad4561-d4e1-44e4-b68e-ee960951501d"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3414), new Guid("5f2519f5-cb88-444b-ae25-7aaf1b04e96b"), 1, null, new Guid("55db46d7-caa2-413d-a663-5d555ade7123") },
                    { new Guid("9ae21310-5ab0-41f8-9732-8dc18cc751d3"), new Guid("84a40ff7-aac4-43ce-af5e-12bc3e41a0e6"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2589), new Guid("e32a5d9c-3bac-47c5-8890-cd0c73aff7fa"), 1, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("9f1ce9ee-84ec-4052-8047-32350c0f0f0b"), new Guid("9aae6ee8-d4b6-43ac-bd8a-7848b302e290"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2178), new Guid("ddd9d84e-5bb8-4512-b625-c5d4a06ea948"), 0, null, new Guid("636c929a-e7d7-461f-9c90-d011cd1918e2") },
                    { new Guid("a3b740e4-6074-40a3-b0e9-98bbebaec2cb"), new Guid("4fc887bb-4cf6-4eb5-a0e2-40c03432f37f"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1828), new Guid("4a10d10f-b5f7-47d4-8e34-dd4d77fd1914"), 1, null, new Guid("faba7073-9f80-4e89-a09b-046bc537e1ea") },
                    { new Guid("a4cdb734-d0d1-40d0-b727-b1fc7cd67fc8"), new Guid("a0a90ad6-eaaf-46fe-9bd0-c8c00da3ee8b"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2672), new Guid("ad5dda94-c78d-4410-abd0-c88129aaafd5"), 0, null, new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9") },
                    { new Guid("a9fb093b-c636-4611-95f3-1c57bfd272fd"), new Guid("c83a425d-5683-4856-8274-0e8c295d3002"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3395), new Guid("f676fb1c-fbaa-404d-980d-a38ac73f038e"), 1, null, new Guid("7f6b4fa5-44af-4ec3-9f5d-4bbcef346d3a") },
                    { new Guid("aa397af8-1aa2-4c4b-9870-6c10b03b2dd2"), new Guid("c6703a80-c6ab-4420-b6b8-8d5b2623d0b8"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2935), new Guid("c292f624-03eb-46b9-8b06-022c70a71921"), 0, null, new Guid("2e66da9d-5bc7-43bb-b450-737a13019b30") },
                    { new Guid("aa7a2df1-2482-41d7-8837-eb5fc1ce1b1f"), new Guid("8e5ed374-2f5b-4065-b8e7-22b95e3868f6"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2281), new Guid("f4383a94-9162-4f41-9849-5f8147bb1fb1"), 1, null, new Guid("d92cc4fb-ef95-4edc-8fc1-014a1a33269e") },
                    { new Guid("ad35c227-b162-4d1e-87ba-313980ae9e5a"), new Guid("559bd96e-2721-456f-b794-ce36c5deb5cf"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3245), new Guid("eb088506-a028-4d69-8a55-c79bcaf1852f"), 1, null, new Guid("ab5cea50-762d-41cd-8e14-d2beac94f682") },
                    { new Guid("ae97d120-784e-41eb-b46d-bf4ad8da6d88"), new Guid("827eaf74-a329-4ead-8b68-93915fa86e57"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2876), new Guid("198aa3b2-20a5-4e94-b91b-260550a91b1a"), 1, null, new Guid("80b5ac0a-25e6-4fc7-880e-76a50b285dd3") },
                    { new Guid("af3e7f3b-9c3f-483a-bb9e-37b7808456ae"), new Guid("7593222e-341d-40f4-a451-764a2c570634"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3093), new Guid("caeab430-35c3-47f6-bfc4-602db8f32413"), 0, null, new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53") },
                    { new Guid("b130bae7-ee97-4779-9bc3-c58d0a4398f7"), new Guid("167f8969-69aa-4072-8ef3-cfd1cd30847e"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2097), new Guid("7b80a425-d303-41d9-b739-d372ce57e540"), 1, null, new Guid("636c929a-e7d7-461f-9c90-d011cd1918e2") },
                    { new Guid("b2b07751-9870-451d-953f-fa525716dbc6"), new Guid("343aa821-a88f-4747-aa44-6790c907e81f"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1955), new Guid("e7eb8521-87ec-4f80-ba0d-60f3de197b3f"), 0, null, new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53") },
                    { new Guid("b6dc8b41-f067-43a2-a1a5-b3235811f24b"), new Guid("9e9acc5a-9c1d-44af-bbab-8a722d6c5aca"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3036), new Guid("f53bf0fd-041c-482f-be9f-dbf062fddc00"), 0, null, new Guid("faba7073-9f80-4e89-a09b-046bc537e1ea") },
                    { new Guid("b845a784-6a50-4420-a234-254a992d182e"), new Guid("043bbd7f-f38e-425a-afd0-d3fd6b07a0c9"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2736), new Guid("9a09e349-c8c9-457f-a2c2-4add74bacf70"), 0, null, new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9") },
                    { new Guid("bad10e0f-542d-42c4-95c1-e687f03b1b30"), new Guid("7abc8737-253a-46ee-b1cf-d60dfe6b8a8d"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2612), new Guid("a830d091-5893-4c1a-8b8f-7d52746423da"), 0, null, new Guid("3aa3d068-8f55-4de7-9207-2f58a7cc7acf") },
                    { new Guid("bbb45d47-c2d4-4b02-8cc0-19f439c7b03f"), new Guid("634b798f-ae01-4942-bcf8-36c79b413bdd"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2240), new Guid("e580f9f4-7c7d-45f7-bd9b-a7662c571268"), 0, null, new Guid("9ef33eca-7121-4d23-8f72-499b7845ce53") },
                    { new Guid("bcbb3a1b-a463-4cbc-8254-5b9066bf3eca"), new Guid("98319de5-e39e-4a80-ba6f-054d1e92d0f0"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1595), new Guid("b761d79d-373f-45c9-86d4-7a4fa3c2d722"), 1, null, new Guid("6fce17c2-a2ba-45a7-9f06-d26c2f49bab0") },
                    { new Guid("bdb62b6d-8b06-4805-8012-4fd4663629af"), new Guid("044e8d1f-ca5c-4130-907f-e41c5b72602c"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2468), new Guid("2a0c9262-c3ab-4121-8f7f-d4fdfab51c43"), 0, null, new Guid("071e7c9b-d059-4a3e-95e4-395709477ef4") },
                    { new Guid("c46b16a5-06d9-4a03-bfba-705e2b752cbe"), new Guid("53c84396-1508-4643-9d10-eb9fbcbaceb6"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2503), new Guid("5d88d472-3fef-4492-9ed1-33b9229afb18"), 1, null, new Guid("d92cc4fb-ef95-4edc-8fc1-014a1a33269e") },
                    { new Guid("c84cab6f-c2a7-4526-a097-0b2a5c7ddd65"), new Guid("c5f9c028-a111-4e0e-8e47-0285aed730fa"), new DateTime(2023, 5, 11, 15, 46, 21, 788, DateTimeKind.Local).AddTicks(5948), new Guid("b25f09da-8381-45e1-9b9f-8a0d5f244850"), 1, null, new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9") },
                    { new Guid("c998b46d-3178-4623-bcef-90472f6bccf9"), new Guid("6c765818-72ca-44aa-ab71-64a8bcdc0f22"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2486), new Guid("d6b6aa20-b9a2-4ae8-ac8e-8b11458a1abc"), 1, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("cb84575c-56ff-4146-b8a8-d827eed91e0c"), new Guid("5744d96e-c16b-4426-b2eb-abab28eeed42"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3274), new Guid("31e3af77-5bd0-4205-8651-0314a7a0ffd2"), 0, null, new Guid("c062d7a6-84c5-4369-8d3c-e35cbcde7160") },
                    { new Guid("cd5b0cb0-dc21-4033-acff-cb9d5f7a0227"), new Guid("80e206e1-8d17-4ad7-a1f1-8ce0372d03eb"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2034), new Guid("a9377083-cd32-4fab-8025-43236d49c0e1"), 1, null, new Guid("3db6bff2-8438-42ed-b14d-a2dc7eb87f9e") },
                    { new Guid("d1a0e61f-7005-42a6-b046-5c176f850ba1"), new Guid("099c4e38-62bb-4bc4-b985-ac42af634dc9"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2717), new Guid("3f42e90e-772c-44af-bc3a-65d350b63755"), 0, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("d4e52d04-14ba-4f56-ad5f-f446a7fcaf9b"), new Guid("4cccb7cc-0683-44bb-8883-003c815592a3"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2439), new Guid("7c222fde-957d-4712-ae20-96be739cc5ed"), 0, null, new Guid("47b001aa-a865-4ba2-889d-f08b50366816") },
                    { new Guid("dd2145ee-e512-44d4-a3eb-e95e6043f7be"), new Guid("c1ca5694-e4b0-481a-8425-77033a853357"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2793), new Guid("8fd881e0-16ad-4a33-b85b-7f69d89ab82b"), 1, null, new Guid("f07a157f-2de2-40f5-84da-2ddf50a2ed35") },
                    { new Guid("dd507cda-a692-4d52-bf4d-9186b65e9a8c"), new Guid("6eba1ee3-3c3d-48ff-a45b-51efeba56879"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1934), new Guid("f0d6ff2e-7f36-4d4b-9397-4e365507b35a"), 1, null, new Guid("a379789d-81a2-4f8a-a2c9-87f3c2d523a9") },
                    { new Guid("e6aafc53-b831-44d0-941f-b2f9bc500d42"), new Guid("80697f80-d6ed-4c6d-abf1-16d242d109a7"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2157), new Guid("703605d7-abb7-4609-88b8-eee2bade798b"), 1, null, new Guid("47b001aa-a865-4ba2-889d-f08b50366816") },
                    { new Guid("e7819d9e-1ac2-4d28-8049-378767a17c59"), new Guid("c42b5a4a-5a10-4108-bb08-4c42b9a5457b"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3056), new Guid("b182fb3b-b0fa-436b-9cf4-7163fee4a4d1"), 0, null, new Guid("d92cc4fb-ef95-4edc-8fc1-014a1a33269e") },
                    { new Guid("e87a1733-ba4a-44d4-9f1d-41990b199d7d"), new Guid("74a1be3e-1454-4bd5-9665-e6e27c640a55"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2971), new Guid("fd5bd548-d7e7-4331-91d8-bb84b3c958f4"), 1, null, new Guid("2e66da9d-5bc7-43bb-b450-737a13019b30") },
                    { new Guid("ee83e080-fbc4-4d74-83cf-a29783ab4515"), new Guid("51a6dbb0-30cb-412e-b170-b0c7430f3870"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3450), new Guid("2d73bb95-a5d5-421a-9a1d-e1e2c16719d4"), 0, null, new Guid("6fce17c2-a2ba-45a7-9f06-d26c2f49bab0") },
                    { new Guid("f622c7c2-40b5-4a07-8f72-7f9039be67e5"), new Guid("10e5255a-a916-47c7-9e88-aad6d9dff3ad"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(1875), new Guid("d881a309-bfe6-43a7-b10a-0a81b43a079f"), 0, null, new Guid("94729f88-8dff-4713-8dc0-b82601274451") },
                    { new Guid("f8d1f22f-cf24-4ab9-b34e-3d558fcc8ecc"), new Guid("70ac1cdd-adeb-4272-b044-9b0fcb0d0ba1"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(3339), new Guid("9ecd38ee-2c36-4905-b4df-2e1ea2292247"), 0, null, new Guid("47b001aa-a865-4ba2-889d-f08b50366816") },
                    { new Guid("fde93a8e-574e-4670-8a00-adf563342e51"), new Guid("ac8c8b86-1d07-48f3-a35c-c736365ee2bf"), new DateTime(2023, 5, 11, 15, 46, 21, 789, DateTimeKind.Local).AddTicks(2138), new Guid("274314a0-6649-4d60-a64e-b300bd141c74"), 0, null, new Guid("55db46d7-caa2-413d-a663-5d555ade7123") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_BankAccountId",
                table: "PaymentMethods",
                column: "BankAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_CreditCardId",
                table: "PaymentMethods",
                column: "CreditCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_UserId",
                table: "PaymentMethods",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "CreditCards");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
