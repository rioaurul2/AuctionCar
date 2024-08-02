using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionCar.Migrations
{
    /// <inheritdoc />
    public partial class AddLotStatusToLotModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Lots",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lots_StatusId",
                table: "Lots",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_LotStatuses_StatusId",
                table: "Lots",
                column: "StatusId",
                principalTable: "LotStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_LotStatuses_StatusId",
                table: "Lots");

            migrationBuilder.DropIndex(
                name: "IX_Lots_StatusId",
                table: "Lots");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Lots");
        }
    }
}
