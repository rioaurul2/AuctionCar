using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionCar.Migrations
{
    /// <inheritdoc />
    public partial class CreateVehicleAsociatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Lots_LotId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_LotId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "LotId",
                table: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Lots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDamaged",
                table: "Vehicles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VehicleDetailsId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VehicleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    NoOfDors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleAccesories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Merchandise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleDetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleAccesories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleAccesories_VehicleDetails_VehicleDetailsId",
                        column: x => x.VehicleDetailsId,
                        principalTable: "VehicleDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VehicleAccesories_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lots_VehicleId",
                table: "Lots",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleDetailsId",
                table: "Vehicles",
                column: "VehicleDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAccesories_VehicleDetailsId",
                table: "VehicleAccesories",
                column: "VehicleDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAccesories_VehicleId",
                table: "VehicleAccesories",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Vehicles_VehicleId",
                table: "Lots",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleDetails_VehicleDetailsId",
                table: "Vehicles",
                column: "VehicleDetailsId",
                principalTable: "VehicleDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Vehicles_VehicleId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleDetails_VehicleDetailsId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleAccesories");

            migrationBuilder.DropTable(
                name: "VehicleDetails");

            migrationBuilder.DropIndex(
                name: "IX_Lots_VehicleId",
                table: "Lots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleDetailsId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Lots");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "IsDamaged",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleDetailsId",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "LotId",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_LotId",
                table: "Vehicle",
                column: "LotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Lots_LotId",
                table: "Vehicle",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id");
        }
    }
}
