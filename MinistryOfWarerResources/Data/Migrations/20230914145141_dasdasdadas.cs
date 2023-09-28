using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class dasdasdadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09iasdlkamsoidu9a8sdkasmd",
                column: "ConcurrencyStamp",
                value: "5002f5f9-db3c-46c2-82e2-13f782f15a4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "a9b28438-3b4c-407f-90e0-83fceac4a3f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "SecurityStamp" },
                values: new object[] { "773559a0-b646-4bd7-ac21-ff09a9d61144", "admin", "admin", "45f335ba-ffb2-464c-8bf4-ad2978eb6dd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09iasdlkamsoidu9a8sdkasmd",
                column: "ConcurrencyStamp",
                value: "b4dc6aac-61b8-4a96-9d08-07f7fa6517cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "39f6fb04-569b-409e-b2d5-06fe3521eeed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "SecurityStamp" },
                values: new object[] { "2f47cc1a-2f3a-411b-aa1a-e42972ee88be", "Ali", "Ali", "bb97c41c-6644-4bfa-884d-a73cd5581ba5" });
        }
    }
}
