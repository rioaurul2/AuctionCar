using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionCar.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAdminColumnToBuyers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Buyers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Buyers");
        }
    }
}
