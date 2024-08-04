using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionCar.Migrations
{
    /// <inheritdoc />
    public partial class ChangeVehicleAccesoryFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAccesories_VehicleDetails_VehicleDetailsId",
                table: "VehicleAccesories");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAccesories_Vehicles_VehicleId",
                table: "VehicleAccesories");

            migrationBuilder.DropIndex(
                name: "IX_VehicleAccesories_VehicleDetailsId",
                table: "VehicleAccesories");

            migrationBuilder.DropColumn(
                name: "VehicleDetailsId",
                table: "VehicleAccesories");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "VehicleAccesories",
                newName: "VehicleDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleAccesories_VehicleId",
                table: "VehicleAccesories",
                newName: "IX_VehicleAccesories_VehicleDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAccesories_VehicleDetails_VehicleDetailId",
                table: "VehicleAccesories",
                column: "VehicleDetailId",
                principalTable: "VehicleDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleAccesories_VehicleDetails_VehicleDetailId",
                table: "VehicleAccesories");

            migrationBuilder.RenameColumn(
                name: "VehicleDetailId",
                table: "VehicleAccesories",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleAccesories_VehicleDetailId",
                table: "VehicleAccesories",
                newName: "IX_VehicleAccesories_VehicleId");

            migrationBuilder.AddColumn<int>(
                name: "VehicleDetailsId",
                table: "VehicleAccesories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VehicleAccesories_VehicleDetailsId",
                table: "VehicleAccesories",
                column: "VehicleDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAccesories_VehicleDetails_VehicleDetailsId",
                table: "VehicleAccesories",
                column: "VehicleDetailsId",
                principalTable: "VehicleDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleAccesories_Vehicles_VehicleId",
                table: "VehicleAccesories",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
