using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class simplle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Brake_BrakeId",
                table: "Motorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Electric_ElectricId",
                table: "Motorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Engine_EngineId",
                table: "Motorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Fuel_FuelId",
                table: "Motorcycle");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Transmission_TransmissionId",
                table: "Motorcycle");

            migrationBuilder.DropTable(
                name: "Brake");

            migrationBuilder.DropTable(
                name: "Electric");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropTable(
                name: "BackBrake");

            migrationBuilder.DropTable(
                name: "FrontBrake");

            migrationBuilder.DropTable(
                name: "Battery");

            migrationBuilder.DropTable(
                name: "Ignition");

            migrationBuilder.DropTable(
                name: "Start");

            migrationBuilder.DropTable(
                name: "Cooling");

            migrationBuilder.DropTable(
                name: "Cylinder");

            migrationBuilder.DropTable(
                name: "TimeCycle");

            migrationBuilder.DropTable(
                name: "Feeding");

            migrationBuilder.DropTable(
                name: "TypeFuel");

            migrationBuilder.DropTable(
                name: "AmountGear");

            migrationBuilder.DropTable(
                name: "TypeTransmission");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycle_BrakeId",
                table: "Motorcycle");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycle_ElectricId",
                table: "Motorcycle");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycle_EngineId",
                table: "Motorcycle");

            migrationBuilder.DropIndex(
                name: "IX_Motorcycle_FuelId",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "BrakeId",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "ElectricId",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Motorcycle");

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Motorcycle");

            migrationBuilder.RenameColumn(
                name: "TransmissionId",
                table: "Motorcycle",
                newName: "DisplacementId");

            migrationBuilder.RenameIndex(
                name: "IX_Motorcycle_TransmissionId",
                table: "Motorcycle",
                newName: "IX_Motorcycle_DisplacementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Displacement_DisplacementId",
                table: "Motorcycle",
                column: "DisplacementId",
                principalTable: "Displacement",
                principalColumn: "DisplacementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycle_Displacement_DisplacementId",
                table: "Motorcycle");

            migrationBuilder.RenameColumn(
                name: "DisplacementId",
                table: "Motorcycle",
                newName: "TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Motorcycle_DisplacementId",
                table: "Motorcycle",
                newName: "IX_Motorcycle_TransmissionId");

            migrationBuilder.AddColumn<int>(
                name: "BrakeId",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectricId",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FuelId",
                table: "Motorcycle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AmountGear",
                columns: table => new
                {
                    AmountGearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmountGear", x => x.AmountGearId);
                });

            migrationBuilder.CreateTable(
                name: "BackBrake",
                columns: table => new
                {
                    BackBrakeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackBrake", x => x.BackBrakeeId);
                });

            migrationBuilder.CreateTable(
                name: "Battery",
                columns: table => new
                {
                    BatteryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battery", x => x.BatteryId);
                });

            migrationBuilder.CreateTable(
                name: "Cooling",
                columns: table => new
                {
                    CoolingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooling", x => x.CoolingId);
                });

            migrationBuilder.CreateTable(
                name: "Cylinder",
                columns: table => new
                {
                    CylinderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cylinder", x => x.CylinderId);
                });

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
                name: "FrontBrake",
                columns: table => new
                {
                    FrontBrakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrontBrake", x => x.FrontBrakeId);
                });

            migrationBuilder.CreateTable(
                name: "Ignition",
                columns: table => new
                {
                    IgnitionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ignition", x => x.IgnitionId);
                });

            migrationBuilder.CreateTable(
                name: "Start",
                columns: table => new
                {
                    StartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Start", x => x.StartId);
                });

            migrationBuilder.CreateTable(
                name: "TimeCycle",
                columns: table => new
                {
                    TimeCycleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeCycle", x => x.TimeCycleId);
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

            migrationBuilder.CreateTable(
                name: "TypeTransmission",
                columns: table => new
                {
                    TypeTransmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeTransmission", x => x.TypeTransmissionId);
                });

            migrationBuilder.CreateTable(
                name: "Brake",
                columns: table => new
                {
                    BrakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BackBrakeId = table.Column<int>(nullable: false),
                    FrontBrakeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brake", x => x.BrakeId);
                    table.ForeignKey(
                        name: "FK_Brake_BackBrake_BackBrakeId",
                        column: x => x.BackBrakeId,
                        principalTable: "BackBrake",
                        principalColumn: "BackBrakeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Brake_FrontBrake_FrontBrakeId",
                        column: x => x.FrontBrakeId,
                        principalTable: "FrontBrake",
                        principalColumn: "FrontBrakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Electric",
                columns: table => new
                {
                    ElectricId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatteryId = table.Column<int>(nullable: false),
                    IgnitionId = table.Column<int>(nullable: false),
                    StartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Electric", x => x.ElectricId);
                    table.ForeignKey(
                        name: "FK_Electric_Battery_BatteryId",
                        column: x => x.BatteryId,
                        principalTable: "Battery",
                        principalColumn: "BatteryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Electric_Ignition_IgnitionId",
                        column: x => x.IgnitionId,
                        principalTable: "Ignition",
                        principalColumn: "IgnitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Electric_Start_StartId",
                        column: x => x.StartId,
                        principalTable: "Start",
                        principalColumn: "StartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engine",
                columns: table => new
                {
                    EngineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoolingId = table.Column<int>(nullable: false),
                    CylinderId = table.Column<int>(nullable: false),
                    DisplacementId = table.Column<int>(nullable: false),
                    TimeCycleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine", x => x.EngineId);
                    table.ForeignKey(
                        name: "FK_Engine_Cooling_CoolingId",
                        column: x => x.CoolingId,
                        principalTable: "Cooling",
                        principalColumn: "CoolingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_Cylinder_CylinderId",
                        column: x => x.CylinderId,
                        principalTable: "Cylinder",
                        principalColumn: "CylinderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_Displacement_DisplacementId",
                        column: x => x.DisplacementId,
                        principalTable: "Displacement",
                        principalColumn: "DisplacementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_TimeCycle_TimeCycleId",
                        column: x => x.TimeCycleId,
                        principalTable: "TimeCycle",
                        principalColumn: "TimeCycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    FuelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<double>(nullable: false),
                    FeedingId = table.Column<int>(nullable: false),
                    TypeFuelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.FuelId);
                    table.ForeignKey(
                        name: "FK_Fuel_Feeding_FeedingId",
                        column: x => x.FeedingId,
                        principalTable: "Feeding",
                        principalColumn: "FeedingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fuel_TypeFuel_TypeFuelId",
                        column: x => x.TypeFuelId,
                        principalTable: "TypeFuel",
                        principalColumn: "TypeFuelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transmission",
                columns: table => new
                {
                    TransmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AmountGearId = table.Column<int>(nullable: false),
                    TypeTransmissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmission", x => x.TransmissionId);
                    table.ForeignKey(
                        name: "FK_Transmission_AmountGear_AmountGearId",
                        column: x => x.AmountGearId,
                        principalTable: "AmountGear",
                        principalColumn: "AmountGearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transmission_TypeTransmission_TypeTransmissionId",
                        column: x => x.TypeTransmissionId,
                        principalTable: "TypeTransmission",
                        principalColumn: "TypeTransmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_BrakeId",
                table: "Motorcycle",
                column: "BrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_ElectricId",
                table: "Motorcycle",
                column: "ElectricId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_EngineId",
                table: "Motorcycle",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_FuelId",
                table: "Motorcycle",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Brake_BackBrakeId",
                table: "Brake",
                column: "BackBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Brake_FrontBrakeId",
                table: "Brake",
                column: "FrontBrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Electric_BatteryId",
                table: "Electric",
                column: "BatteryId");

            migrationBuilder.CreateIndex(
                name: "IX_Electric_IgnitionId",
                table: "Electric",
                column: "IgnitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Electric_StartId",
                table: "Electric",
                column: "StartId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_CoolingId",
                table: "Engine",
                column: "CoolingId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_CylinderId",
                table: "Engine",
                column: "CylinderId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_DisplacementId",
                table: "Engine",
                column: "DisplacementId");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_TimeCycleId",
                table: "Engine",
                column: "TimeCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_FeedingId",
                table: "Fuel",
                column: "FeedingId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_TypeFuelId",
                table: "Fuel",
                column: "TypeFuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_AmountGearId",
                table: "Transmission",
                column: "AmountGearId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_TypeTransmissionId",
                table: "Transmission",
                column: "TypeTransmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Brake_BrakeId",
                table: "Motorcycle",
                column: "BrakeId",
                principalTable: "Brake",
                principalColumn: "BrakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Electric_ElectricId",
                table: "Motorcycle",
                column: "ElectricId",
                principalTable: "Electric",
                principalColumn: "ElectricId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Engine_EngineId",
                table: "Motorcycle",
                column: "EngineId",
                principalTable: "Engine",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Fuel_FuelId",
                table: "Motorcycle",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "FuelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycle_Transmission_TransmissionId",
                table: "Motorcycle",
                column: "TransmissionId",
                principalTable: "Transmission",
                principalColumn: "TransmissionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
