using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feeding",
                table: "Fuel");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Fuel");

            migrationBuilder.AddColumn<int>(
                name: "FeedingId",
                table: "Fuel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeFuelId",
                table: "Fuel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Feeding",
                columns: table => new
                {
                    FeedingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeding", x => x.FeedingId);
                });

            migrationBuilder.CreateTable(
                name: "TypeFuel",
                columns: table => new
                {
                    TypeFuelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFuel", x => x.TypeFuelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_FeedingId",
                table: "Fuel",
                column: "FeedingId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_TypeFuelId",
                table: "Fuel",
                column: "TypeFuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fuel_Feeding_FeedingId",
                table: "Fuel",
                column: "FeedingId",
                principalTable: "Feeding",
                principalColumn: "FeedingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fuel_TypeFuel_TypeFuelId",
                table: "Fuel",
                column: "TypeFuelId",
                principalTable: "TypeFuel",
                principalColumn: "TypeFuelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fuel_Feeding_FeedingId",
                table: "Fuel");

            migrationBuilder.DropForeignKey(
                name: "FK_Fuel_TypeFuel_TypeFuelId",
                table: "Fuel");

            migrationBuilder.DropTable(
                name: "Feeding");

            migrationBuilder.DropTable(
                name: "TypeFuel");

            migrationBuilder.DropIndex(
                name: "IX_Fuel_FeedingId",
                table: "Fuel");

            migrationBuilder.DropIndex(
                name: "IX_Fuel_TypeFuelId",
                table: "Fuel");

            migrationBuilder.DropColumn(
                name: "FeedingId",
                table: "Fuel");

            migrationBuilder.DropColumn(
                name: "TypeFuelId",
                table: "Fuel");

            migrationBuilder.AddColumn<string>(
                name: "Feeding",
                table: "Fuel",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Fuel",
                nullable: false,
                defaultValue: "");
        }
    }
}
