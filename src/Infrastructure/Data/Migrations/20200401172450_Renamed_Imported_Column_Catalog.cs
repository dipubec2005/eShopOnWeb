using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    public partial class Renamed_Imported_Column_Catalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imported",
                table: "Catalog");

            migrationBuilder.AddColumn<bool>(
                name: "Fragile",
                table: "Catalog",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fragile",
                table: "Catalog");

            migrationBuilder.AddColumn<bool>(
                name: "Imported",
                table: "Catalog",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
