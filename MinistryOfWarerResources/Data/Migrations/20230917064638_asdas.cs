using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class asdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "77b050fc-b52f-425f-9e63-9ec89058f642");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                column: "ConcurrencyStamp",
                value: "09e7acdc-4afa-484c-b275-d68992c91312");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "9d414771-2fec-4c7f-acd0-dccbb1d9ba2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d39c993-fe15-46fc-904c-b583a670b2a3", "2f5a6dc9-3a00-45a6-ac9a-f1fcc609b243" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dASDasdasdasdsa", 0, "68bbccee-69e0-4b49-921c-8b093c6b7161", "owner", true, false, null, "owner", "OWNER", "000000", null, false, "facf0a7a-a787-4293-9c58-f1f6c792ed25", false, "owner" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDasdasdasdsa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "38612448-1518-4476-83ff-66cdecdcf689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                column: "ConcurrencyStamp",
                value: "7b8c7409-4f2e-455e-8b03-7fc00edc5f2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "2fcfb1d6-4413-403c-9d3c-0777503d0243");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f613a61e-96ed-47ac-9614-a4070d87d4c1", "b0a73466-b7cf-486d-bf6c-04d587fe90fa" });
        }
    }
}
