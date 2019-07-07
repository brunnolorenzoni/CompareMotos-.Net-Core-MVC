using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompareMotos.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
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
                name: "Dimensions",
                columns: table => new
                {
                    DimensionsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Length = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.DimensionsId);
                });

            migrationBuilder.CreateTable(
                name: "Displacement",
                columns: table => new
                {
                    DisplacementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displacement", x => x.DisplacementId);
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
                name: "Fuel",
                columns: table => new
                {
                    FuelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Capacity = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Feeding = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.FuelId);
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
                name: "ModelMotorcycle",
                columns: table => new
                {
                    ModelMotorcycleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelMotorcycle", x => x.ModelMotorcycleId);
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
                name: "TypeMotorcycle",
                columns: table => new
                {
                    TypeMotorcycleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeMotorcycle", x => x.TypeMotorcycleId);
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
                    FrontBrakeId = table.Column<int>(nullable: false),
                    BackBrakeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brake", x => x.BrakeId);
                    table.ForeignKey(
                        name: "FK_Brake_BackBrake_BackBrakeeId",
                        column: x => x.BackBrakeeId,
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
                    IgnitionId = table.Column<int>(nullable: false),
                    StartId = table.Column<int>(nullable: false),
                    BatteryId = table.Column<int>(nullable: false)
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
                    TimeCycleId = table.Column<int>(nullable: false),
                    CylinderId = table.Column<int>(nullable: false),
                    DisplacementId = table.Column<int>(nullable: false),
                    CoolingId = table.Column<int>(nullable: false)
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
                name: "Transmission",
                columns: table => new
                {
                    TransmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeTransmissionId = table.Column<int>(nullable: false),
                    AmountGearId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Motorcycle",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TypeMotorcycleId = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    ModelMotorcycleId = table.Column<int>(nullable: false),
                    EngineId = table.Column<int>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    ElectricId = table.Column<int>(nullable: false),
                    BrakeId = table.Column<int>(nullable: false),
                    TransmissionId = table.Column<int>(nullable: false),
                    DimensionsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycle", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Brake_BrakeId",
                        column: x => x.BrakeId,
                        principalTable: "Brake",
                        principalColumn: "BrakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Dimensions_DimensionsId",
                        column: x => x.DimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "DimensionsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Electric_ElectricId",
                        column: x => x.ElectricId,
                        principalTable: "Electric",
                        principalColumn: "ElectricId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "EngineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Fuel_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuel",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_ModelMotorcycle_ModelMotorcycleId",
                        column: x => x.ModelMotorcycleId,
                        principalTable: "ModelMotorcycle",
                        principalColumn: "ModelMotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Transmission_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmission",
                        principalColumn: "TransmissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_TypeMotorcycle_TypeMotorcycleId",
                        column: x => x.TypeMotorcycleId,
                        principalTable: "TypeMotorcycle",
                        principalColumn: "TypeMotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brake_BackBrakeeId",
                table: "Brake",
                column: "BackBrakeeId");

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
                name: "IX_Motorcycle_BrakeId",
                table: "Motorcycle",
                column: "BrakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_BrandId",
                table: "Motorcycle",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_DimensionsId",
                table: "Motorcycle",
                column: "DimensionsId");

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
                name: "IX_Motorcycle_ModelMotorcycleId",
                table: "Motorcycle",
                column: "ModelMotorcycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_TransmissionId",
                table: "Motorcycle",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_TypeMotorcycleId",
                table: "Motorcycle",
                column: "TypeMotorcycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_AmountGearId",
                table: "Transmission",
                column: "AmountGearId");

            migrationBuilder.CreateIndex(
                name: "IX_Transmission_TypeTransmissionId",
                table: "Transmission",
                column: "TypeTransmissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motorcycle");

            migrationBuilder.DropTable(
                name: "Brake");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Electric");

            migrationBuilder.DropTable(
                name: "Engine");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropTable(
                name: "ModelMotorcycle");

            migrationBuilder.DropTable(
                name: "Transmission");

            migrationBuilder.DropTable(
                name: "TypeMotorcycle");

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
                name: "Displacement");

            migrationBuilder.DropTable(
                name: "TimeCycle");

            migrationBuilder.DropTable(
                name: "AmountGear");

            migrationBuilder.DropTable(
                name: "TypeTransmission");
        }
    }
}
