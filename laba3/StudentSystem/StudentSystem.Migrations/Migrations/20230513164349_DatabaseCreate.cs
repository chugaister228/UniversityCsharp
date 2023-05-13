using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentSystem.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Resources_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homeworks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeworks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Homeworks_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Homeworks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "EndDate", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"), "Quibusdam sed eaque nobis ad nam eligendi repudiandae. Aperiam dolorem voluptatum ut ut vitae delectus quibusdam. Enim laboriosam occaecati aperiam sed.", new DateTime(2024, 2, 2, 10, 45, 49, 57, DateTimeKind.Local).AddTicks(1154), "minus", 0.8409123330450940m, new DateTime(2024, 2, 18, 17, 37, 55, 618, DateTimeKind.Local).AddTicks(8322) },
                    { new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"), "ad", new DateTime(2024, 5, 6, 2, 38, 17, 524, DateTimeKind.Local).AddTicks(5280), "odio", 0.1221514291174860m, new DateTime(2024, 2, 17, 22, 47, 30, 260, DateTimeKind.Local).AddTicks(2102) },
                    { new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"), "Odio ut ab recusandae.", new DateTime(2024, 5, 9, 18, 10, 21, 866, DateTimeKind.Local).AddTicks(5458), "atque", 0.6555891310643010m, new DateTime(2023, 5, 31, 14, 7, 7, 938, DateTimeKind.Local).AddTicks(6846) },
                    { new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"), "Commodi sint nam voluptas.", new DateTime(2023, 9, 23, 7, 32, 54, 518, DateTimeKind.Local).AddTicks(5505), "enim", 0.3222355035509850m, new DateTime(2023, 5, 29, 13, 19, 1, 434, DateTimeKind.Local).AddTicks(4377) },
                    { new Guid("8559bd31-6af8-4350-9925-bb37336007c3"), "Quia debitis aspernatur accusamus rerum aut quae nihil ea.", new DateTime(2023, 11, 24, 3, 44, 59, 862, DateTimeKind.Local).AddTicks(1727), "eaque", 0.3100244091938440m, new DateTime(2024, 1, 6, 14, 50, 10, 64, DateTimeKind.Local).AddTicks(3635) },
                    { new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"), "maxime", new DateTime(2023, 8, 29, 8, 9, 31, 324, DateTimeKind.Local).AddTicks(1236), "eos", 0.9855314801850370m, new DateTime(2023, 11, 12, 23, 6, 59, 311, DateTimeKind.Local).AddTicks(128) },
                    { new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"), "est", new DateTime(2023, 6, 27, 12, 8, 15, 28, DateTimeKind.Local).AddTicks(2218), "a", 0.4151486365307090m, new DateTime(2024, 2, 19, 16, 34, 20, 931, DateTimeKind.Local).AddTicks(4193) },
                    { new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"), "Deserunt ea tenetur nostrum voluptas quidem ab maiores cupiditate eum.\nRepellat accusamus molestiae cupiditate eius molestias deserunt.\nAnimi ex error neque.\nAccusantium voluptatem repellendus impedit omnis vitae quia fugit at omnis.\nBeatae dolorem aut perferendis.\nTempora iure in quis voluptas impedit adipisci.", new DateTime(2023, 5, 28, 14, 38, 35, 656, DateTimeKind.Local).AddTicks(1883), "minima", 0.0696733317853070m, new DateTime(2024, 4, 29, 22, 16, 33, 435, DateTimeKind.Local).AddTicks(8755) },
                    { new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"), "magni", new DateTime(2023, 5, 15, 11, 14, 17, 919, DateTimeKind.Local).AddTicks(7787), "sed", 0.970806794884840m, new DateTime(2023, 12, 28, 7, 49, 34, 539, DateTimeKind.Local).AddTicks(1609) },
                    { new Guid("ece3f119-48d2-4377-b665-c10790a4f497"), "Et sed officia eos accusamus atque voluptatibus. Aut veritatis cum dolores quo. Atque dolores enim eum et numquam aut amet non sit.", new DateTime(2023, 6, 16, 13, 27, 21, 557, DateTimeKind.Local).AddTicks(7783), "eligendi", 0.8275002601482640m, new DateTime(2023, 6, 28, 21, 16, 49, 420, DateTimeKind.Local).AddTicks(7327) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthday", "Name", "PhoneNumber", "RegisteredOn" },
                values: new object[,]
                {
                    { new Guid("424f4c5c-342d-4505-bd50-b796d3948537"), new DateTime(2022, 6, 15, 20, 56, 40, 7, DateTimeKind.Local).AddTicks(6781), "Brad", "536.785.6308 x36939", new DateTime(2023, 4, 3, 12, 7, 59, 842, DateTimeKind.Local).AddTicks(407) },
                    { new Guid("7c1d9057-1d16-4768-be6e-dc86bea68bcc"), new DateTime(2022, 11, 15, 1, 19, 0, 731, DateTimeKind.Local).AddTicks(2383), "Rudy", "(213) 889-1976", new DateTime(2022, 10, 1, 20, 54, 18, 129, DateTimeKind.Local).AddTicks(9246) },
                    { new Guid("91752c83-c6ab-45b9-8fef-ec0513acb86e"), new DateTime(2022, 5, 30, 4, 34, 43, 471, DateTimeKind.Local).AddTicks(9694), "Daisy", "1-619-312-4033", new DateTime(2022, 12, 30, 10, 38, 45, 11, DateTimeKind.Local).AddTicks(1256) },
                    { new Guid("95a90528-198c-410e-9c69-b5ff5bbee33b"), new DateTime(2022, 8, 28, 23, 32, 4, 317, DateTimeKind.Local).AddTicks(2347), "Freddie", "(675) 410-7624 x638", new DateTime(2022, 9, 1, 15, 9, 12, 598, DateTimeKind.Local).AddTicks(3200) },
                    { new Guid("aa6b27d0-fd3d-4d47-ba93-a56d4169c0d7"), new DateTime(2023, 1, 27, 0, 29, 38, 289, DateTimeKind.Local).AddTicks(9592), "Kristopher", "259-908-2229 x4167", new DateTime(2022, 12, 7, 14, 36, 14, 309, DateTimeKind.Local).AddTicks(5110) },
                    { new Guid("ceac166c-814c-4e82-9fc8-696f2b1f409d"), new DateTime(2022, 5, 24, 12, 3, 29, 11, DateTimeKind.Local).AddTicks(7394), "Eileen", "750.776.5510 x4352", new DateTime(2022, 7, 4, 5, 33, 29, 475, DateTimeKind.Local).AddTicks(3413) },
                    { new Guid("d4369c9c-1a31-4903-b077-4e6e4f929953"), new DateTime(2023, 1, 24, 23, 13, 47, 797, DateTimeKind.Local).AddTicks(2342), "Sophie", "1-686-722-7498 x9299", new DateTime(2022, 7, 1, 7, 0, 20, 325, DateTimeKind.Local).AddTicks(1597) },
                    { new Guid("df6533ac-bfcd-4a18-a4d7-4858b70a1ed8"), new DateTime(2023, 3, 8, 1, 45, 7, 613, DateTimeKind.Local).AddTicks(7694), "Bryan", "1-501-368-6175 x4477", new DateTime(2022, 8, 13, 12, 14, 42, 811, DateTimeKind.Local).AddTicks(6504) },
                    { new Guid("e9ec51cb-735c-4c9a-a461-64f24f66307c"), new DateTime(2023, 1, 21, 20, 38, 20, 729, DateTimeKind.Local).AddTicks(4628), "Colin", "1-963-754-1779", new DateTime(2023, 1, 18, 17, 50, 8, 230, DateTimeKind.Local).AddTicks(5747) },
                    { new Guid("f9bdeab3-dd65-4090-ae38-19455e52626f"), new DateTime(2023, 4, 21, 7, 42, 10, 652, DateTimeKind.Local).AddTicks(5711), "Natasha", "(681) 676-1359 x3036", new DateTime(2022, 12, 6, 13, 24, 15, 397, DateTimeKind.Local).AddTicks(4537) }
                });

            migrationBuilder.InsertData(
                table: "Homeworks",
                columns: new[] { "ID", "Content", "ContentType", "CourseId", "StudentId", "SubmissionTime" },
                values: new object[,]
                {
                    { new Guid("0a5f19a0-ef72-4b4f-8d1b-eaefbbb3125c"), "Ad et quidem sit corrupti.", "Aplication", new Guid("8559bd31-6af8-4350-9925-bb37336007c3"), new Guid("91752c83-c6ab-45b9-8fef-ec0513acb86e"), new DateTime(2023, 12, 31, 23, 10, 46, 84, DateTimeKind.Local).AddTicks(4427) },
                    { new Guid("33cf8263-21c6-41d0-ad96-ba6a07843bae"), "Delectus aliquid vel autem sed explicabo tenetur autem culpa.\nDoloremque occaecati consequatur molestiae porro temporibus.\nCorrupti modi est ipsa aut similique aspernatur.\nCorporis dolorum accusantium hic.\nDoloremque tempore est sit nulla molestiae pariatur.", "Aplication", new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"), new Guid("7c1d9057-1d16-4768-be6e-dc86bea68bcc"), new DateTime(2023, 11, 23, 0, 43, 23, 595, DateTimeKind.Local).AddTicks(4698) },
                    { new Guid("8761b7bd-a488-43d3-aa11-d23b4f43343c"), "saepe", "Zip", new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"), new Guid("aa6b27d0-fd3d-4d47-ba93-a56d4169c0d7"), new DateTime(2023, 7, 21, 7, 10, 9, 327, DateTimeKind.Local).AddTicks(6727) },
                    { new Guid("90a0a3dc-7d6c-4fd7-b7eb-c2ba11b29a11"), "Amet labore autem voluptas voluptatem dignissimos earum non qui. Sunt iusto accusantium aperiam ut eos facere. In facere sint occaecati distinctio minima molestiae. Asperiores minus ut et culpa. Dolore sunt provident.", "Zip", new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"), new Guid("f9bdeab3-dd65-4090-ae38-19455e52626f"), new DateTime(2023, 7, 4, 22, 32, 17, 394, DateTimeKind.Local).AddTicks(5609) },
                    { new Guid("9e014769-87ad-47bd-a704-d80e1a5c6e0d"), "Explicabo omnis sed ut et sed sit corrupti.", "Aplication", new Guid("ece3f119-48d2-4377-b665-c10790a4f497"), new Guid("d4369c9c-1a31-4903-b077-4e6e4f929953"), new DateTime(2024, 4, 1, 22, 27, 37, 648, DateTimeKind.Local).AddTicks(2764) },
                    { new Guid("be97f850-5e09-4e25-b897-1a8134926d0d"), "cumque", "Aplication", new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"), new Guid("df6533ac-bfcd-4a18-a4d7-4858b70a1ed8"), new DateTime(2024, 4, 12, 6, 16, 53, 389, DateTimeKind.Local).AddTicks(1472) },
                    { new Guid("d58f5980-662d-4ae0-9320-2ede7524025a"), "consequatur", "Pdf", new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"), new Guid("ceac166c-814c-4e82-9fc8-696f2b1f409d"), new DateTime(2023, 12, 23, 22, 5, 56, 433, DateTimeKind.Local).AddTicks(2992) },
                    { new Guid("d76038ef-e7bc-4ad8-b0dc-367eeaa0eef8"), "Libero ducimus possimus qui voluptas enim consequatur occaecati libero.\nCumque itaque quos odit.\nAut officia et quis adipisci dolore eligendi.\nConsequatur id eligendi exercitationem iure dignissimos.", "Zip", new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"), new Guid("e9ec51cb-735c-4c9a-a461-64f24f66307c"), new DateTime(2024, 3, 13, 11, 50, 7, 805, DateTimeKind.Local).AddTicks(8874) },
                    { new Guid("ea4d8d49-bc9e-44ee-a7e7-1f2d3ff81088"), "Quia possimus recusandae recusandae consequuntur ipsum dicta possimus at et. Impedit asperiores id id aut eos ea debitis vero consequatur. Aut qui ipsam vel. Veniam et nemo autem nostrum rerum voluptatem beatae dolorem.", "Zip", new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"), new Guid("95a90528-198c-410e-9c69-b5ff5bbee33b"), new DateTime(2023, 7, 22, 12, 22, 36, 667, DateTimeKind.Local).AddTicks(2307) },
                    { new Guid("eac0cdcd-bcc8-4c6f-9bee-f84a121f68ab"), "reiciendis", "Pdf", new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"), new Guid("424f4c5c-342d-4505-bd50-b796d3948537"), new DateTime(2024, 3, 3, 12, 46, 35, 305, DateTimeKind.Local).AddTicks(8910) }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "CourseId", "Name", "ResourceType", "Url" },
                values: new object[,]
                {
                    { new Guid("25ec3571-fbfe-4ab8-9dcb-23a5e084361b"), new Guid("3cf5ed96-7176-4c8f-88d9-e1d2708b534e"), "delectus", "Document", "http://mallory.org" },
                    { new Guid("2a7659b2-2a91-459e-8988-4f1f78c6e44a"), new Guid("759b63e1-dd4e-48ed-8bb0-96e042a49ed4"), "incidunt", "Other", "https://emilie.net" },
                    { new Guid("2bc57d4f-3276-428d-9e3f-78eeec433606"), new Guid("8559bd31-6af8-4350-9925-bb37336007c3"), "a", "Document", "https://stanley.net" },
                    { new Guid("44b81464-4c1a-4b93-b0c9-a077e67b6a26"), new Guid("bd0c604f-0b0c-4a6a-8efe-b5705b83bd51"), "nesciunt", "Other", "https://abel.name" },
                    { new Guid("47b758da-b6da-4a42-ba5f-11e6d4f71c03"), new Guid("e7bc0305-a3cc-4f37-bb61-09f365cc3a94"), "omnis", "Video", "http://kristopher.info" },
                    { new Guid("6452c447-9151-4e29-a212-301263c09ab2"), new Guid("ece3f119-48d2-4377-b665-c10790a4f497"), "expedita", "Video", "http://jordane.name" },
                    { new Guid("9e6e89a8-cfb5-49dc-99a5-5f4776c0233b"), new Guid("7569b6bc-2434-464e-a8a7-1b2deea76ec2"), "minima", "Video", "http://jettie.com" },
                    { new Guid("bfcae787-869a-4811-9d86-48b11043775e"), new Guid("bb739aaa-e3f8-4b3c-90ae-eec9511f1af3"), "necessitatibus", "Document", "https://larry.name" },
                    { new Guid("e38588b6-55e3-4d0e-b097-508d99755beb"), new Guid("d8e10ef7-dd00-4753-a1dd-07632d9170c8"), "sapiente", "Video", "https://thomas.name" },
                    { new Guid("f107d6a4-b0f6-4adf-9639-a6b3aeb26a6f"), new Guid("224b6c15-ecff-49cf-ad5f-317e1902ca56"), "accusamus", "Video", "https://winnifred.net" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_CourseId",
                table: "Homeworks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Homeworks_StudentId",
                table: "Homeworks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CourseId",
                table: "Resources",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentId",
                table: "StudentCourses",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homeworks");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
