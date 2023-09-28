using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class saddsaadasaaasdaasgban : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DawwaTable_DepTable_DeptTableId",
                table: "DawwaTable");

            migrationBuilder.DropTable(
                name: "EmpTable");

            migrationBuilder.DropTable(
                name: "DepTable");

            migrationBuilder.DropTable(
                name: "OfficeTable");

            migrationBuilder.DropIndex(
                name: "IX_DawwaTable_DeptTableId",
                table: "DawwaTable");

            migrationBuilder.DropColumn(
                name: "DeptTableId",
                table: "DawwaTable");

            migrationBuilder.AlterColumn<string>(
                name: "Office",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Office",
                table: "DawwaTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DeptTableId",
                table: "DawwaTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OfficeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeTableId = table.Column<int>(type: "int", nullable: false),
                    DepName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepTable_OfficeTable_OfficeTableId",
                        column: x => x.OfficeTableId,
                        principalTable: "OfficeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpDep = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfEmployemnt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpAge = table.Column<int>(type: "int", nullable: false),
                    EmpFullName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EmpImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    EmpSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpTable_DepTable_EmpDep",
                        column: x => x.EmpDep,
                        principalTable: "DepTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DawwaTable_DeptTableId",
                table: "DawwaTable",
                column: "DeptTableId");

            migrationBuilder.CreateIndex(
                name: "IX_DepTable_OfficeTableId",
                table: "DepTable",
                column: "OfficeTableId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpTable_EmpDep",
                table: "EmpTable",
                column: "EmpDep");

            migrationBuilder.AddForeignKey(
                name: "FK_DawwaTable_DepTable_DeptTableId",
                table: "DawwaTable",
                column: "DeptTableId",
                principalTable: "DepTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
