using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Og_Guild_Bank.Migrations
{
    public partial class addedtimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedTs",
                table: "Wallet",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedTs",
                table: "Wallet");
        }
    }
}
