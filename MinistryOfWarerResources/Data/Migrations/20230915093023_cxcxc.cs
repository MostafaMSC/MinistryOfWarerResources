using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class cxcxc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "38612448-1518-4476-83ff-66cdecdcf689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "2fcfb1d6-4413-403c-9d3c-0777503d0243");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdasdasdasdadaasdasdasdad", "7b8c7409-4f2e-455e-8b03-7fc00edc5f2c", "DawaUser", "DAWAUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f613a61e-96ed-47ac-9614-a4070d87d4c1", "b0a73466-b7cf-486d-bf6c-04d587fe90fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "1517e442-d2f8-4d4f-b34e-b5c0a1625eea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "4357b29d-e78f-4766-a068-bf7701898d02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e276f71d-c552-4ad4-89f6-23a8421c7f68", "52ee9fa2-0404-40a8-95fb-12258489f92c" });
        }
    }
}
