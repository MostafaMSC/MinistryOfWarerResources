using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class addmigrationasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DawwaTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectDawa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DawaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Court = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptTableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DawwaTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DawwaTable_DepTable_DeptTableId",
                        column: x => x.DeptTableId,
                        principalTable: "DepTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DawwaTable_DeptTableId",
                table: "DawwaTable",
                column: "DeptTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DawwaTable");
        }
    }
}
