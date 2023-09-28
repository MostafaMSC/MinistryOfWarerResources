using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class dasdasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "2f47cc1a-2f3a-411b-aa1a-e42972ee88be", "admin", "bb97c41c-6644-4bfa-884d-a73cd5581ba5", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09iasdlkamsoidu9a8sdkasmd",
                column: "ConcurrencyStamp",
                value: "19791f50-dba9-4cca-bbec-07406cf031ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "ea600ecb-e99c-4347-8160-7ab341fc4c09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "ea58d35e-8463-4de6-a46e-4f2bcbca6993", "Ali", "70ee6937-40c5-4827-a83c-4c79e7e12fb2", "Ali" });
        }
    }
}
