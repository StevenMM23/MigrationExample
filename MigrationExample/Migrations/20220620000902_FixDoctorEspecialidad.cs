using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationExample.Migrations
{
    public partial class FixDoctorEspecialidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctores_EspecialidadId",
                table: "Doctores");

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_EspecialidadId",
                table: "Doctores",
                column: "EspecialidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Doctores_EspecialidadId",
                table: "Doctores");

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_EspecialidadId",
                table: "Doctores",
                column: "EspecialidadId",
                unique: true);
        }
    }
}
