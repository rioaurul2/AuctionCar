using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionCar.Migrations
{
    /// <inheritdoc />
    public partial class CreateAuctionTableAndPopulateTableAndAddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Auctions",
                newName: "StatusId");

            migrationBuilder.CreateTable(
                name: "AuctionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionStatuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_StatusId",
                table: "Auctions",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_AuctionStatuses_StatusId",
                table: "Auctions",
                column: "StatusId",
                principalTable: "AuctionStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_AuctionStatuses_StatusId",
                table: "Auctions");

            migrationBuilder.DropTable(
                name: "AuctionStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_StatusId",
                table: "Auctions");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Auctions",
                newName: "Status");
        }
    }
}
