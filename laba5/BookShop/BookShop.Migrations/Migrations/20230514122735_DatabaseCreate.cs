using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Copies = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EditionType = table.Column<int>(type: "int", nullable: false),
                    AgeRestriction = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("26a5f753-7cf7-4ff6-928f-756a4d1e13ef"), "Ida", "Ledner" },
                    { new Guid("414923e3-26e5-41ff-8182-c48678786a12"), "Shelly", "Watsica" },
                    { new Guid("53d84a43-53f4-48e8-b286-f27964668e2a"), "Judith", "Schaefer" },
                    { new Guid("643e9724-e8ce-4707-a045-740ce7a2c455"), "Barbara", "Kulas" },
                    { new Guid("789dcb66-2ae4-48ad-b79f-3dbdcc5342fc"), "Edna", "Kris" },
                    { new Guid("908b590a-d111-45d0-809d-240d1aad0b09"), "Brittany", "Jacobi" },
                    { new Guid("cf9063df-2dad-4fda-83ec-74984b21581d"), "Aubrey", "Morar" },
                    { new Guid("e2b2c20d-a498-4f0a-b074-88908b537f1d"), "Meredith", "Cummings" },
                    { new Guid("fa93469a-accb-417b-80ff-a016d34351ce"), "Myron", "Mitchell" },
                    { new Guid("fac1de15-37e0-4b9e-a306-80a0ca6fd894"), "Pearl", "Bins" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("135f754d-cdc7-4577-9f5c-c2e3cc6ddd05"), "Refined Metal Keyboard" },
                    { new Guid("32b456ae-90ac-44fa-b686-645ca794ae8a"), "Licensed Wooden Bike" },
                    { new Guid("5c9ae19e-7bba-4410-b973-af7cc1ab7716"), "Awesome Metal Pizza" },
                    { new Guid("7f102223-53a8-4baa-9558-cb4603ff82ea"), "Practical Metal Shoes" },
                    { new Guid("894a4a1c-9b7b-4f4a-be30-7628b272d80d"), "Small Steel Cheese" },
                    { new Guid("a4ca9d12-89c3-4abd-976f-4ebd7c619f8e"), "Intelligent Fresh Keyboard" },
                    { new Guid("d215a509-8fbf-44d4-94c2-f64fde44a9c3"), "Handcrafted Soft Table" },
                    { new Guid("d909c5a2-b1a8-4dec-8350-2908e697fb49"), "Generic Steel Chair" },
                    { new Guid("dca11dd7-a0e7-4041-b400-db3ebba99978"), "Small Granite Salad" },
                    { new Guid("e926e8ed-0a90-41dd-bad3-ba5dfb8cf755"), "Practical Soft Pants" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AgeRestriction", "AuthorId", "Copies", "Description", "EditionType", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("0e08a9c8-c0a7-4616-b51d-6378172a18f5"), 0, new Guid("53d84a43-53f4-48e8-b286-f27964668e2a"), 1167167827, "Eaque assumenda voluptatem perferendis quisquam voluptatibus omnis voluptas sint repudiandae. Maxime dolor qui qui aliquam voluptatibus iste. Ut sapiente sit nulla. Molestias aut sint in eum tempore. Dolorum autem voluptatem aspernatur quis corrupti quod et. Molestias labore iusto qui sequi ipsam.", 2, 0.7580720791695410m, new DateTime(2023, 5, 11, 15, 49, 55, 134, DateTimeKind.Local).AddTicks(1890), "quisquam" },
                    { new Guid("2c7d3111-093f-406a-a2cf-6826d22f3a36"), 1, new Guid("e2b2c20d-a498-4f0a-b074-88908b537f1d"), 741321544, "Dolores quo omnis in provident animi.\nEligendi dolores officia quo.\nError natus atque dolorem vel minima ut iste.\nCumque earum illum dolorem nesciunt est optio natus molestias pariatur.\nFugit modi illum.", 0, 0.4511424702603020m, new DateTime(2022, 8, 17, 3, 51, 36, 275, DateTimeKind.Local).AddTicks(896), "vel" },
                    { new Guid("338629d5-7c7c-43a1-8e01-e97f90fe2685"), 2, new Guid("cf9063df-2dad-4fda-83ec-74984b21581d"), -1005780169, "Adipisci atque reprehenderit illum repellat iusto et ex. Enim consequatur id dicta. A neque natus recusandae totam. Ut voluptas aliquid ab recusandae qui. Ex sunt maxime aspernatur. Tempora maiores commodi omnis omnis ad ut at quis qui.", 1, 0.5614619162661890m, new DateTime(2023, 4, 21, 4, 25, 38, 562, DateTimeKind.Local).AddTicks(2329), "aliquid" },
                    { new Guid("33f0c0dd-5c7b-4222-a566-01b579bbb3bc"), 2, new Guid("908b590a-d111-45d0-809d-240d1aad0b09"), -804918675, "Dolor ea aut.\nQui nihil ut aliquid sapiente.\nEnim non tempore ad.\nModi ex ea autem quia perferendis quisquam voluptate mollitia perferendis.", 1, 0.415468878204680m, new DateTime(2022, 5, 31, 16, 50, 52, 426, DateTimeKind.Local).AddTicks(7846), "qui" },
                    { new Guid("3f388e31-a6e6-4191-b373-77fe692d1858"), 1, new Guid("414923e3-26e5-41ff-8182-c48678786a12"), -1056779523, "Vel excepturi ex suscipit est vel et nihil.\nInventore eos assumenda labore reprehenderit.", 2, 0.2985640671768220m, new DateTime(2022, 12, 7, 4, 40, 37, 885, DateTimeKind.Local).AddTicks(5442), "reiciendis" },
                    { new Guid("4dddf3f8-3f6b-402e-a0d4-4ea205f53fef"), 0, new Guid("26a5f753-7cf7-4ff6-928f-756a4d1e13ef"), -1319858910, "Itaque nihil alias officia sint voluptatem inventore dolorem quo est.", 2, 0.3096270185915580m, new DateTime(2023, 3, 23, 5, 54, 29, 964, DateTimeKind.Local).AddTicks(8771), "modi" },
                    { new Guid("7848f24a-91d5-471b-8669-83543ea0a761"), 1, new Guid("789dcb66-2ae4-48ad-b79f-3dbdcc5342fc"), -622504344, "Eum iure esse debitis in placeat.\nTotam molestiae veritatis quis et ullam veritatis est.", 0, 0.003446702464206640m, new DateTime(2023, 1, 24, 6, 30, 52, 79, DateTimeKind.Local).AddTicks(1768), "quam" },
                    { new Guid("896e1362-f4d5-4f75-a850-7c202cdcb3b3"), 1, new Guid("fac1de15-37e0-4b9e-a306-80a0ca6fd894"), 663353985, "Mollitia nostrum et rerum eos ut odit voluptas debitis repellendus.", 0, 0.3039416866461670m, new DateTime(2023, 2, 2, 1, 44, 57, 172, DateTimeKind.Local).AddTicks(416), "ad" },
                    { new Guid("b3d0a67c-d035-4b71-bc17-196559911eb4"), 1, new Guid("643e9724-e8ce-4707-a045-740ce7a2c455"), -397187734, "et", 0, 0.7460292643050350m, new DateTime(2023, 1, 21, 7, 9, 12, 270, DateTimeKind.Local).AddTicks(1941), "qui" },
                    { new Guid("b93613c1-3eeb-4823-a52a-eaefd0261be3"), 1, new Guid("fa93469a-accb-417b-80ff-a016d34351ce"), -1588354750, "Molestiae possimus doloremque rerum assumenda provident harum.\nAspernatur commodi ut eos deserunt quisquam.", 2, 0.07789644739903120m, new DateTime(2022, 8, 5, 11, 46, 16, 547, DateTimeKind.Local).AddTicks(3185), "qui" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_BookId",
                table: "BookCategories",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
