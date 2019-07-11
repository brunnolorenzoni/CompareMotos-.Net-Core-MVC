using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class newOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brake_BackBrake_BackBrakeeId",
                table: "Brake");

            migrationBuilder.RenameColumn(
                name: "BackBrakeeId",
                table: "Brake",
                newName: "BackBrakeId");

            migrationBuilder.RenameIndex(
                name: "IX_Brake_BackBrakeeId",
                table: "Brake",
                newName: "IX_Brake_BackBrakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brake_BackBrake_BackBrakeId",
                table: "Brake",
                column: "BackBrakeId",
                principalTable: "BackBrake",
                principalColumn: "BackBrakeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brake_BackBrake_BackBrakeId",
                table: "Brake");

            migrationBuilder.RenameColumn(
                name: "BackBrakeId",
                table: "Brake",
                newName: "BackBrakeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Brake_BackBrakeId",
                table: "Brake",
                newName: "IX_Brake_BackBrakeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brake_BackBrake_BackBrakeeId",
                table: "Brake",
                column: "BackBrakeeId",
                principalTable: "BackBrake",
                principalColumn: "BackBrakeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
