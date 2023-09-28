using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class saddsaadasaaasdaasgbanassdadsdfd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadaPIC",
                table: "JazaeaTable");

            migrationBuilder.DropColumn(
                name: "QrarAlastanafPIC",
                table: "JazaeaTable");

            migrationBuilder.DropColumn(
                name: "TammeezPic",
                table: "JazaeaTable");

            migrationBuilder.DropColumn(
                name: "TashehPIC",
                table: "JazaeaTable");

            migrationBuilder.DropColumn(
                name: "AadaPIC",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "QrarAlastanafPIC",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TammeezPic",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TashehPIC",
                table: "DawwaTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AadaPIC",
                table: "JazaeaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QrarAlastanafPIC",
                table: "JazaeaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TammeezPic",
                table: "JazaeaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TashehPIC",
                table: "JazaeaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AadaPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QrarAlastanafPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TammeezPic",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TashehPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
