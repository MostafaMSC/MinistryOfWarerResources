using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class saddsaadasaaasdaasgbanas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AadaPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AkherALajraaat",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AstanafNO",
                table: "DawwaTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QrarAlastanafPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TameezNO",
                table: "DawwaTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TammeezPic",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TashehNO",
                table: "DawwaTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TashehPIC",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "qraraadaNO",
                table: "DawwaTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AadaPIC",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "AkherALajraaat",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "AstanafNO",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "QrarAlastanafPIC",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TameezNO",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TammeezPic",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TashehNO",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "TashehPIC",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "qraraadaNO",
                table: "DawwaTable");
        }
    }
}
