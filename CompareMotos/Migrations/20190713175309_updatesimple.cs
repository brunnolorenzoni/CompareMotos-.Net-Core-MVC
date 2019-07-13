using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class updatesimple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Year",
                table: "Motorcycle",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Motorcycle",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
