using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public class PatientMedicamentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientMedicament",
                columns: table => new
                {
                    PatientsPatientId = table.Column<int>(nullable: false),
                    MedicamentsMedicamentId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicament", x => new { x.PatientsPatientId, x.MedicamentsMedicamentId });
                    table.ForeignKey(
                        name: "FK_PatientMedicament_Patient_PatientsPatientId",
                        column: x => x.PatientsPatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicament_Medicament_MedicamentsMedicamentId",
                        column: x => x.MedicamentsMedicamentId,
                        principalTable: "Medicament",
                        principalColumn: "MedicamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicament_MedicamentsMedicamentId",
                table: "PatientMedicament",
                column: "MedicamentsMedicamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientMedicament");
        }
    }
}
