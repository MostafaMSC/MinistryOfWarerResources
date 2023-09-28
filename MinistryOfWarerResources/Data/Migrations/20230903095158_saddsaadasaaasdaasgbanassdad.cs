using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class saddsaadasaaasdaasgbanassdad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JazaeaTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectDawa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AstanafNO = table.Column<int>(type: "int", nullable: false),
                    QrarAlastanafPIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TameezNO = table.Column<int>(type: "int", nullable: false),
                    TammeezPic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TashehNO = table.Column<int>(type: "int", nullable: false),
                    TashehPIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    qraraadaNO = table.Column<int>(type: "int", nullable: false),
                    AadaPIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AkherALajraaat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JazaeaTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JazaeaTable");
        }
    }
}
