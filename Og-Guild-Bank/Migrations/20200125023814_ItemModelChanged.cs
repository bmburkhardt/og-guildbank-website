using Microsoft.EntityFrameworkCore.Migrations;

namespace Og_Guild_Bank.Migrations
{
    public partial class ItemModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Items",
                newName: "ItemQuantity");

            migrationBuilder.RenameColumn(
                name: "Quality",
                table: "Items",
                newName: "ItemQuality");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Items",
                newName: "ItemName");

            migrationBuilder.RenameColumn(
                name: "BagSlotId",
                table: "Items",
                newName: "ContainerId");

            migrationBuilder.RenameColumn(
                name: "BadId",
                table: "Items",
                newName: "BagSlot");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemQuantity",
                table: "Items",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ItemQuality",
                table: "Items",
                newName: "Quality");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Items",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ContainerId",
                table: "Items",
                newName: "BagSlotId");

            migrationBuilder.RenameColumn(
                name: "BagSlot",
                table: "Items",
                newName: "BadId");
        }
    }
}
