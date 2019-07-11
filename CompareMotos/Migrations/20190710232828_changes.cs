using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Dimensions_DimensionsId",
                table: "Motorcycle");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycle_DimensionsId",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "DimensionsId",
                table: "Motorcycle");

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Length",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Width",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Motorcycle");

            migrationBuilder.AddColumn<int>(
                name: "DimensionsId",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    DimensionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Height = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.DimensionsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_DimensionsId",
                table: "Motorcycle",
                column: "DimensionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Dimensions_DimensionsId",
                table: "Motorcycle",
                column: "DimensionsId",
                principalTable: "Dimensions",
                principalColumn: "DimensionsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
