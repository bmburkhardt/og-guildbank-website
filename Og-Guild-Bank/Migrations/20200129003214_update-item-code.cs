using Microsoft.EntityFrameworkCore.Migrations;

namespace Og_Guild_Bank.Migrations
{
    public partial class updateitemcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemCd",
                table: "Items",
                newName: "ItemCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemCode",
                table: "Items",
                newName: "ItemCd");
        }
    }
}
