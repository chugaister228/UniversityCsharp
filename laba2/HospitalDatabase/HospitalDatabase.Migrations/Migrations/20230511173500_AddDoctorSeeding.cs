using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalDatabase.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "ID", "Email", "Login", "Name", "Speciality" },
                values: new object[,]
                {
                    { new Guid("0c4ca78d-b24a-47ba-a05b-498e1ce7ca85"), "Jane28@gmail.com", "L5byIzrZ91", "Rodolfo Rowe", "enim" },
                    { new Guid("1d392721-3895-4b16-838e-2c0c39432cec"), "Elroy.Koepp84@gmail.com", "UdGoqnDjTR", "Jody Morar", "delectus" },
                    { new Guid("228adb73-7186-411c-a09f-52e2e1b924d9"), "Lora_Abernathy@gmail.com", "hgqBzf_bs2", "Keith King", "ipsum" },
                    { new Guid("29d35cbd-801b-4c25-b48a-0aa1b74982a7"), "Giuseppe.Emmerich@hotmail.com", "J7aabFqxu6", "Darin Johnston", "aspernatur" },
                    { new Guid("3b8eaea7-0f95-4fc6-af4f-167a35d23106"), "Nicholas94@yahoo.com", "mAdqE8iBGi", "Denise Friesen", "ut" },
                    { new Guid("6387af7c-d16d-4d24-9528-afe8fd9f51d5"), "Winona88@hotmail.com", "8LcTvAFXcQ", "Geraldine Aufderhar", "est" },
                    { new Guid("67bf17e0-3849-4989-8e58-c76939c86f4d"), "Leonel.Durgan56@yahoo.com", "DQYazNpCf4", "Ebony Gutmann", "unde" },
                    { new Guid("6c7a02ce-1baa-4e16-9b9b-c4afd4c42518"), "Randall_Kiehn@hotmail.com", "SQBxPjQybu", "Alexander Kiehn", "omnis" },
                    { new Guid("6cf23575-b8b4-4ebf-82c1-587983bdb826"), "Mauricio.Dicki@gmail.com", "9OJGqpmYAa", "Monique Runte", "quibusdam" },
                    { new Guid("c87525a3-4646-4790-914f-b17eff2c9589"), "Sedrick64@gmail.com", "9j7wxTDzqg", "Johnnie Considine", "atque" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("0c4ca78d-b24a-47ba-a05b-498e1ce7ca85"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("1d392721-3895-4b16-838e-2c0c39432cec"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("228adb73-7186-411c-a09f-52e2e1b924d9"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("29d35cbd-801b-4c25-b48a-0aa1b74982a7"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("3b8eaea7-0f95-4fc6-af4f-167a35d23106"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("6387af7c-d16d-4d24-9528-afe8fd9f51d5"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("67bf17e0-3849-4989-8e58-c76939c86f4d"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("6c7a02ce-1baa-4e16-9b9b-c4afd4c42518"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("6cf23575-b8b4-4ebf-82c1-587983bdb826"));

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "ID",
                keyValue: new Guid("c87525a3-4646-4790-914f-b17eff2c9589"));
        }
    }
}
