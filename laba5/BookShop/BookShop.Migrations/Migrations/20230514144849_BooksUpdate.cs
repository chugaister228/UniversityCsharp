using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class BooksUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0e08a9c8-c0a7-4616-b51d-6378172a18f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2c7d3111-093f-406a-a2cf-6826d22f3a36"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("338629d5-7c7c-43a1-8e01-e97f90fe2685"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("33f0c0dd-5c7b-4222-a566-01b579bbb3bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3f388e31-a6e6-4191-b373-77fe692d1858"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4dddf3f8-3f6b-402e-a0d4-4ea205f53fef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7848f24a-91d5-471b-8669-83543ea0a761"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("896e1362-f4d5-4f75-a850-7c202cdcb3b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b3d0a67c-d035-4b71-bc17-196559911eb4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b93613c1-3eeb-4823-a52a-eaefd0261be3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("135f754d-cdc7-4577-9f5c-c2e3cc6ddd05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("32b456ae-90ac-44fa-b686-645ca794ae8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("5c9ae19e-7bba-4410-b973-af7cc1ab7716"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7f102223-53a8-4baa-9558-cb4603ff82ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("894a4a1c-9b7b-4f4a-be30-7628b272d80d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a4ca9d12-89c3-4abd-976f-4ebd7c619f8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("d215a509-8fbf-44d4-94c2-f64fde44a9c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("d909c5a2-b1a8-4dec-8350-2908e697fb49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("dca11dd7-a0e7-4041-b400-db3ebba99978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e926e8ed-0a90-41dd-bad3-ba5dfb8cf755"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("26a5f753-7cf7-4ff6-928f-756a4d1e13ef"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("414923e3-26e5-41ff-8182-c48678786a12"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("53d84a43-53f4-48e8-b286-f27964668e2a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("643e9724-e8ce-4707-a045-740ce7a2c455"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("789dcb66-2ae4-48ad-b79f-3dbdcc5342fc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("908b590a-d111-45d0-809d-240d1aad0b09"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cf9063df-2dad-4fda-83ec-74984b21581d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e2b2c20d-a498-4f0a-b074-88908b537f1d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("fa93469a-accb-417b-80ff-a016d34351ce"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("fac1de15-37e0-4b9e-a306-80a0ca6fd894"));

            migrationBuilder.AlterColumn<string>(
                name: "EditionType",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AgeRestriction",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("163154dd-77c9-4148-9488-57da9aa2a57c"), "Alonzo", "Johnston" },
                    { new Guid("1ac06311-3a34-4702-a539-4e2696b739b1"), "Lola", "Collins" },
                    { new Guid("1e48cc58-3e7e-4e1b-9c47-dc9f3356feb8"), "Ramon", "Nienow" },
                    { new Guid("4a0c7d3e-8d2d-4415-b126-6ac0dec57591"), "Kara", "Stokes" },
                    { new Guid("7e8bc934-6bc9-4ba6-9351-9a5b95c47f15"), "Joshua", "Bergstrom" },
                    { new Guid("c49a3f52-c761-4569-aced-e6d1f42fc4a7"), "Lyle", "Little" },
                    { new Guid("d1ccaa76-7503-4629-9a55-65f38a3349c4"), "Edgar", "Jenkins" },
                    { new Guid("d2ee3e81-dc2b-4e52-b3cb-834909103425"), "Robyn", "Ferry" },
                    { new Guid("e08a96ed-d185-45a9-aa08-22a9c3c81712"), "Nora", "Dickens" },
                    { new Guid("f8e2abbe-bb3f-41d4-a76a-21a773ce2d36"), "Jesse", "Wisozk" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("134fc345-0af9-45fd-8b37-1e210908a1e4"), "Intelligent Wooden Salad" },
                    { new Guid("3db7fc9b-8797-4209-87fa-f61dbf86362b"), "Awesome Concrete Pizza" },
                    { new Guid("4b241b52-baf4-4abc-aab4-f6a679ca95d3"), "Intelligent Cotton Bike" },
                    { new Guid("4dc7c321-7c4c-4526-8059-249c34a5e941"), "Fantastic Frozen Shoes" },
                    { new Guid("6fa6d230-5488-44f6-a6d6-49967235f5d3"), "Sleek Soft Shoes" },
                    { new Guid("70247d7b-9c23-40e4-a4e6-0a82b016898f"), "Intelligent Soft Gloves" },
                    { new Guid("8d6e6e7d-9a18-44c3-9caf-65e58bc94eb4"), "Licensed Frozen Keyboard" },
                    { new Guid("a97026cf-ec00-43b9-8478-c205e13cb11d"), "Handcrafted Concrete Chair" },
                    { new Guid("ab582bae-c642-428f-b4e7-e14873a2053c"), "Licensed Rubber Keyboard" },
                    { new Guid("e55c88bd-b895-4efd-95c9-8841f9debed8"), "Intelligent Rubber Tuna" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AgeRestriction", "AuthorId", "Copies", "Description", "EditionType", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("073211a4-6b8e-4b05-b535-c9e608c08bf1"), "Adult", new Guid("e08a96ed-d185-45a9-aa08-22a9c3c81712"), 1137575458, "Vel ad beatae soluta. Dignissimos deleniti autem consequuntur dolores accusantium et et id. Consequatur porro rerum quia voluptate aut et ab. Sunt temporibus ipsa natus maxime omnis a sed quis necessitatibus.", "Promo", 0.157021184943110m, new DateTime(2023, 3, 1, 10, 49, 52, 680, DateTimeKind.Local).AddTicks(6639), "possimus" },
                    { new Guid("29eab18d-4bbc-48c7-b19b-6da3f2b61737"), "Teen", new Guid("f8e2abbe-bb3f-41d4-a76a-21a773ce2d36"), 731431633, "Enim et voluptas sapiente quia porro ut aut. Accusantium dignissimos hic saepe. Consequatur saepe quia possimus. Odio enim harum provident fugiat architecto ullam eaque qui. Facere quia reiciendis sit eos omnis. Nam ut vitae excepturi.", "Gold", 0.2187478726320470m, new DateTime(2022, 9, 30, 19, 32, 17, 447, DateTimeKind.Local).AddTicks(2868), "provident" },
                    { new Guid("3082fc7b-e628-424d-af3c-490abe3c2562"), "Minor", new Guid("d1ccaa76-7503-4629-9a55-65f38a3349c4"), -964355123, "Nulla nihil placeat omnis beatae eveniet sint qui delectus.\nLaborum deleniti voluptatem alias aspernatur animi odio.\nIste enim voluptas nobis eaque optio ducimus.", "Normal", 0.6782728600186450m, new DateTime(2022, 5, 25, 11, 51, 46, 435, DateTimeKind.Local).AddTicks(6850), "sequi" },
                    { new Guid("42307fa6-4a94-4474-b4b5-d06f370dc5a9"), "Teen", new Guid("c49a3f52-c761-4569-aced-e6d1f42fc4a7"), -959455389, "Saepe quo itaque aut at qui repellendus. Delectus aut atque fugiat. Autem voluptatem laborum et quisquam ad. Dolore aliquid incidunt impedit voluptatem occaecati voluptatem. Aut atque temporibus ducimus. Enim deleniti quo dolorem et dolor reprehenderit ut ex.", "Normal", 0.7199468266049980m, new DateTime(2022, 10, 23, 23, 28, 26, 532, DateTimeKind.Local).AddTicks(1904), "et" },
                    { new Guid("723c4735-1327-45e2-b33b-c54a496184ba"), "Adult", new Guid("4a0c7d3e-8d2d-4415-b126-6ac0dec57591"), 1693156380, "Temporibus ea voluptas veritatis dolorem voluptatibus consequatur.", "Promo", 0.2044289371685540m, new DateTime(2023, 4, 19, 5, 1, 32, 566, DateTimeKind.Local).AddTicks(377), "ullam" },
                    { new Guid("976ff3c1-6f68-41b6-87ab-d441cfbee937"), "Minor", new Guid("7e8bc934-6bc9-4ba6-9351-9a5b95c47f15"), -677177094, "Accusamus sint qui ex officiis.\nAccusantium modi aut eos consequatur ut sequi eum ipsum quia.", "Gold", 0.4071174326469190m, new DateTime(2022, 11, 4, 23, 51, 5, 99, DateTimeKind.Local).AddTicks(5173), "autem" },
                    { new Guid("a4c18d35-d549-42f7-aafb-d8d1d8e731af"), "Minor", new Guid("163154dd-77c9-4148-9488-57da9aa2a57c"), -1838443634, "Possimus sunt repellat reprehenderit.\nEveniet officia dolore repellendus recusandae fugiat aut.\nId doloribus sunt.\nVitae dolores qui temporibus.", "Normal", 0.7139135149085090m, new DateTime(2022, 6, 22, 20, 34, 52, 973, DateTimeKind.Local).AddTicks(9580), "eius" },
                    { new Guid("e1c5b7de-3687-49ad-95a1-c1da244047e8"), "Minor", new Guid("1ac06311-3a34-4702-a539-4e2696b739b1"), -1156261051, "Inventore voluptatem sapiente veniam aut fugiat quas quisquam.", "Normal", 0.5439696916057880m, new DateTime(2022, 5, 25, 0, 37, 35, 561, DateTimeKind.Local).AddTicks(7926), "eum" },
                    { new Guid("f38cb4dd-1230-4426-b574-56955a2b3893"), "Teen", new Guid("1e48cc58-3e7e-4e1b-9c47-dc9f3356feb8"), 1818735980, "Fugiat et sed voluptatem ut iure quaerat repudiandae aut.", "Normal", 0.8598095343150630m, new DateTime(2022, 10, 28, 13, 29, 59, 383, DateTimeKind.Local).AddTicks(8118), "quis" },
                    { new Guid("fe3d7c94-ec0b-4430-b1e7-517fb2c1a4c4"), "Teen", new Guid("d2ee3e81-dc2b-4e52-b3cb-834909103425"), -20632630, "Qui suscipit veniam voluptas ipsam quidem consequatur. Nulla nobis cupiditate deserunt eos et qui consequatur. Ullam laboriosam blanditiis.", "Normal", 0.1902058787706120m, new DateTime(2023, 2, 4, 18, 24, 24, 890, DateTimeKind.Local).AddTicks(7437), "facere" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("073211a4-6b8e-4b05-b535-c9e608c08bf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("29eab18d-4bbc-48c7-b19b-6da3f2b61737"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3082fc7b-e628-424d-af3c-490abe3c2562"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("42307fa6-4a94-4474-b4b5-d06f370dc5a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("723c4735-1327-45e2-b33b-c54a496184ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("976ff3c1-6f68-41b6-87ab-d441cfbee937"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a4c18d35-d549-42f7-aafb-d8d1d8e731af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e1c5b7de-3687-49ad-95a1-c1da244047e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f38cb4dd-1230-4426-b574-56955a2b3893"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fe3d7c94-ec0b-4430-b1e7-517fb2c1a4c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("134fc345-0af9-45fd-8b37-1e210908a1e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("3db7fc9b-8797-4209-87fa-f61dbf86362b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4b241b52-baf4-4abc-aab4-f6a679ca95d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4dc7c321-7c4c-4526-8059-249c34a5e941"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6fa6d230-5488-44f6-a6d6-49967235f5d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("70247d7b-9c23-40e4-a4e6-0a82b016898f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("8d6e6e7d-9a18-44c3-9caf-65e58bc94eb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a97026cf-ec00-43b9-8478-c205e13cb11d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("ab582bae-c642-428f-b4e7-e14873a2053c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e55c88bd-b895-4efd-95c9-8841f9debed8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("163154dd-77c9-4148-9488-57da9aa2a57c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1ac06311-3a34-4702-a539-4e2696b739b1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1e48cc58-3e7e-4e1b-9c47-dc9f3356feb8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("4a0c7d3e-8d2d-4415-b126-6ac0dec57591"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7e8bc934-6bc9-4ba6-9351-9a5b95c47f15"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("c49a3f52-c761-4569-aced-e6d1f42fc4a7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("d1ccaa76-7503-4629-9a55-65f38a3349c4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("d2ee3e81-dc2b-4e52-b3cb-834909103425"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e08a96ed-d185-45a9-aa08-22a9c3c81712"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f8e2abbe-bb3f-41d4-a76a-21a773ce2d36"));

            migrationBuilder.AlterColumn<int>(
                name: "EditionType",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AgeRestriction",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
