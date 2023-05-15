using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShop.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddBookCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("3a2d791e-583a-4662-ab51-9d8b1cbfdbcd"), "Loretta", "Bartoletti" },
                    { new Guid("425cc76a-51e2-4936-9e2d-45adb6eaeab7"), "Aaron", "Reynolds" },
                    { new Guid("72e7d6be-375c-4e61-8748-ad48e9e3fa0a"), "Stephanie", "Volkman" },
                    { new Guid("7fd3fd55-7dc8-4b43-9bb4-f4b2c7a6774f"), "Martha", "Gibson" },
                    { new Guid("8ce39313-8048-461b-a24a-4407d7ffa279"), "Gayle", "Abshire" },
                    { new Guid("af7031d3-bdea-4c7f-9fa2-8c2bd6df8242"), "Jonathan", "Heidenreich" },
                    { new Guid("b125bb8a-9ae3-44ff-80fc-8c288267243b"), "Maryann", "Heaney" },
                    { new Guid("b987dbac-c5f1-47f1-a779-6ae36a67ce9f"), "Sheryl", "Johnson" },
                    { new Guid("ded6da13-017b-44e7-88c8-2378b7bd070e"), "Randal", "Kihn" },
                    { new Guid("f4b3a56c-26bd-46f7-9a52-f56debb06b72"), "Rufus", "Reilly" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { new Guid("11335047-fec0-46d0-9146-a89d6eb493e6"), "Sleek Rubber Towels" },
                    { new Guid("44e5bbe1-5de0-4727-b710-4d4821086525"), "Ergonomic Soft Table" },
                    { new Guid("4fde3afd-d835-4183-9eea-bf164763bb42"), "Fantastic Soft Car" },
                    { new Guid("50fb19c9-622d-486f-acb0-b6ca4afc3ccf"), "Refined Frozen Chips" },
                    { new Guid("5a6b551f-a144-4a66-9257-dc579aa5ba8b"), "Sleek Plastic Sausages" },
                    { new Guid("66fed8ea-7ed1-497b-899a-33952dccf4f7"), "Handmade Cotton Fish" },
                    { new Guid("87d2092b-25a4-488c-8aa3-009f1af2f1fb"), "Licensed Soft Hat" },
                    { new Guid("b5e2ef01-4dc2-4e4d-abde-23b7090ccf05"), "Sleek Concrete Ball" },
                    { new Guid("bc255372-a1b2-4178-b4a8-17181c1d54ae"), "Handmade Granite Mouse" },
                    { new Guid("e2d30c4f-16a6-49b1-a7d6-d456dae4214b"), "Handmade Fresh Mouse" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AgeRestriction", "AuthorId", "Copies", "Description", "EditionType", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("208728cf-e2a2-41aa-9368-c3d512b33fc3"), "Teen", new Guid("ded6da13-017b-44e7-88c8-2378b7bd070e"), 1255373519, "sequi", "Normal", 0.5101704643303390m, new DateTime(2023, 5, 7, 3, 18, 17, 503, DateTimeKind.Local).AddTicks(8254), "ut" },
                    { new Guid("47f48838-4e31-43ba-ba2d-4438ce88bc03"), "Minor", new Guid("8ce39313-8048-461b-a24a-4407d7ffa279"), -1020617682, "Accusamus aut enim.", "Promo", 0.1055123422380130m, new DateTime(2023, 4, 8, 4, 54, 49, 144, DateTimeKind.Local).AddTicks(1668), "ut" },
                    { new Guid("51c8501b-74ea-4265-ba03-d9be0ac36146"), "Minor", new Guid("af7031d3-bdea-4c7f-9fa2-8c2bd6df8242"), 875023876, "Est doloribus animi aspernatur ut.\nSunt doloremque quam aspernatur.\nPerferendis fuga aliquam quae error quod repudiandae dolore tenetur.\nMolestiae incidunt sed dolor vitae tempora earum.\nAlias dolor a iure est voluptatem fugit.", "Gold", 0.01116485524477010m, new DateTime(2022, 11, 18, 14, 44, 13, 266, DateTimeKind.Local).AddTicks(3351), "ipsam" },
                    { new Guid("6c6cfe2d-5422-453c-9a33-bbf196c5b1f5"), "Teen", new Guid("b987dbac-c5f1-47f1-a779-6ae36a67ce9f"), -802658577, "Tenetur et possimus perspiciatis reiciendis rem id. Neque eum aut maiores veniam quasi blanditiis et. Asperiores magni eum tempora laudantium soluta. Iure dolorum quia voluptatem voluptates et labore iste qui impedit. Explicabo consequatur dolor.", "Promo", 0.8105701997163920m, new DateTime(2022, 9, 2, 17, 31, 38, 518, DateTimeKind.Local).AddTicks(5565), "aut" },
                    { new Guid("8a0e1647-4184-4b69-909b-21a5c59c70fe"), "Adult", new Guid("b125bb8a-9ae3-44ff-80fc-8c288267243b"), 1973523133, "repudiandae", "Normal", 0.712783271989850m, new DateTime(2023, 4, 23, 12, 8, 56, 777, DateTimeKind.Local).AddTicks(1043), "illo" },
                    { new Guid("94728229-d603-4e2a-8f19-8cae9ea59f20"), "Minor", new Guid("3a2d791e-583a-4662-ab51-9d8b1cbfdbcd"), -2111999642, "repudiandae", "Normal", 0.114046987701470m, new DateTime(2022, 10, 1, 14, 26, 9, 535, DateTimeKind.Local).AddTicks(9310), "aut" },
                    { new Guid("9ee007a6-e224-4dfa-b364-61401523a21a"), "Teen", new Guid("72e7d6be-375c-4e61-8748-ad48e9e3fa0a"), 17579283, "Ex delectus quia eum repellat ab aliquam dolor.\nAdipisci velit et.\nCorporis dolorem voluptatem id.\nPerferendis suscipit ut sunt qui.\nDolorem sit voluptatem error error occaecati consequatur.\nOmnis recusandae quia nulla quia id ut culpa.", "Gold", 0.3255572582775080m, new DateTime(2022, 11, 7, 10, 41, 52, 547, DateTimeKind.Local).AddTicks(9441), "corrupti" },
                    { new Guid("c3e44c54-5b6d-4d02-86d5-542deda63925"), "Minor", new Guid("425cc76a-51e2-4936-9e2d-45adb6eaeab7"), -1832437662, "Laboriosam alias excepturi sequi accusantium id at tempora ut non. Ut deserunt cupiditate cum vero quaerat alias assumenda optio. Natus ut distinctio consequatur asperiores officiis et odio.", "Gold", 0.14232120811360m, new DateTime(2022, 7, 28, 0, 11, 36, 575, DateTimeKind.Local).AddTicks(5944), "explicabo" },
                    { new Guid("c926d52d-62ef-4d81-8385-338b8956c5f7"), "Adult", new Guid("f4b3a56c-26bd-46f7-9a52-f56debb06b72"), -1176790940, "Facilis maxime non non incidunt eius cumque inventore.\nEst sit autem minus sint rerum illo.", "Normal", 0.9700161129182830m, new DateTime(2022, 10, 15, 20, 12, 59, 894, DateTimeKind.Local).AddTicks(2501), "explicabo" },
                    { new Guid("d0f1cd48-2741-4d3d-9395-6cbc683f5d2c"), "Minor", new Guid("7fd3fd55-7dc8-4b43-9bb4-f4b2c7a6774f"), -1192479933, "Dolorem provident soluta doloremque labore minus eos consequuntur explicabo. Atque eum eius atque consectetur optio fuga magni. Totam nulla possimus. Earum rerum autem ex neque quos beatae.", "Promo", 0.9654429640078880m, new DateTime(2022, 11, 20, 1, 40, 32, 571, DateTimeKind.Local).AddTicks(4235), "impedit" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "ID", "BookId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("110c06bc-f316-4c9c-a857-5e6679067707"), new Guid("c926d52d-62ef-4d81-8385-338b8956c5f7"), new Guid("50fb19c9-622d-486f-acb0-b6ca4afc3ccf") },
                    { new Guid("1eac508e-cd86-4b7e-b233-f8749cc21a4b"), new Guid("51c8501b-74ea-4265-ba03-d9be0ac36146"), new Guid("e2d30c4f-16a6-49b1-a7d6-d456dae4214b") },
                    { new Guid("37cfd3f9-3ce2-4fca-8afe-bb805f03b3c6"), new Guid("94728229-d603-4e2a-8f19-8cae9ea59f20"), new Guid("87d2092b-25a4-488c-8aa3-009f1af2f1fb") },
                    { new Guid("590f8ddf-12a4-47cf-8e83-285ed04cfd24"), new Guid("c3e44c54-5b6d-4d02-86d5-542deda63925"), new Guid("b5e2ef01-4dc2-4e4d-abde-23b7090ccf05") },
                    { new Guid("72996fcb-ee0a-4b0e-86ed-690e12530b74"), new Guid("6c6cfe2d-5422-453c-9a33-bbf196c5b1f5"), new Guid("5a6b551f-a144-4a66-9257-dc579aa5ba8b") },
                    { new Guid("8fab705d-17e4-4105-9e70-d98488541705"), new Guid("47f48838-4e31-43ba-ba2d-4438ce88bc03"), new Guid("4fde3afd-d835-4183-9eea-bf164763bb42") },
                    { new Guid("afd17a8a-4cf4-487a-b9bf-8bae57e1a83c"), new Guid("d0f1cd48-2741-4d3d-9395-6cbc683f5d2c"), new Guid("bc255372-a1b2-4178-b4a8-17181c1d54ae") },
                    { new Guid("cfb401de-a377-47f9-a7d2-ab8e8f71a62a"), new Guid("9ee007a6-e224-4dfa-b364-61401523a21a"), new Guid("11335047-fec0-46d0-9146-a89d6eb493e6") },
                    { new Guid("dc567919-3a5b-48eb-8051-d424da937be5"), new Guid("208728cf-e2a2-41aa-9368-c3d512b33fc3"), new Guid("66fed8ea-7ed1-497b-899a-33952dccf4f7") },
                    { new Guid("e81633e0-c88c-44f4-85d4-26f15812f5c7"), new Guid("8a0e1647-4184-4b69-909b-21a5c59c70fe"), new Guid("44e5bbe1-5de0-4727-b710-4d4821086525") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("110c06bc-f316-4c9c-a857-5e6679067707"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("1eac508e-cd86-4b7e-b233-f8749cc21a4b"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("37cfd3f9-3ce2-4fca-8afe-bb805f03b3c6"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("590f8ddf-12a4-47cf-8e83-285ed04cfd24"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("72996fcb-ee0a-4b0e-86ed-690e12530b74"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("8fab705d-17e4-4105-9e70-d98488541705"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("afd17a8a-4cf4-487a-b9bf-8bae57e1a83c"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("cfb401de-a377-47f9-a7d2-ab8e8f71a62a"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("dc567919-3a5b-48eb-8051-d424da937be5"));

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumn: "ID",
                keyValue: new Guid("e81633e0-c88c-44f4-85d4-26f15812f5c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("208728cf-e2a2-41aa-9368-c3d512b33fc3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("47f48838-4e31-43ba-ba2d-4438ce88bc03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("51c8501b-74ea-4265-ba03-d9be0ac36146"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6c6cfe2d-5422-453c-9a33-bbf196c5b1f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8a0e1647-4184-4b69-909b-21a5c59c70fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("94728229-d603-4e2a-8f19-8cae9ea59f20"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9ee007a6-e224-4dfa-b364-61401523a21a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c3e44c54-5b6d-4d02-86d5-542deda63925"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c926d52d-62ef-4d81-8385-338b8956c5f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d0f1cd48-2741-4d3d-9395-6cbc683f5d2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("11335047-fec0-46d0-9146-a89d6eb493e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("44e5bbe1-5de0-4727-b710-4d4821086525"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4fde3afd-d835-4183-9eea-bf164763bb42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("50fb19c9-622d-486f-acb0-b6ca4afc3ccf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("5a6b551f-a144-4a66-9257-dc579aa5ba8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("66fed8ea-7ed1-497b-899a-33952dccf4f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("87d2092b-25a4-488c-8aa3-009f1af2f1fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("b5e2ef01-4dc2-4e4d-abde-23b7090ccf05"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bc255372-a1b2-4178-b4a8-17181c1d54ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e2d30c4f-16a6-49b1-a7d6-d456dae4214b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("3a2d791e-583a-4662-ab51-9d8b1cbfdbcd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("425cc76a-51e2-4936-9e2d-45adb6eaeab7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("72e7d6be-375c-4e61-8748-ad48e9e3fa0a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7fd3fd55-7dc8-4b43-9bb4-f4b2c7a6774f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("8ce39313-8048-461b-a24a-4407d7ffa279"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("af7031d3-bdea-4c7f-9fa2-8c2bd6df8242"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b125bb8a-9ae3-44ff-80fc-8c288267243b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b987dbac-c5f1-47f1-a779-6ae36a67ce9f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ded6da13-017b-44e7-88c8-2378b7bd070e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f4b3a56c-26bd-46f7-9a52-f56debb06b72"));

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
    }
}
