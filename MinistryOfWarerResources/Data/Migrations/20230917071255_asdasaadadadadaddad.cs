using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class asdasaadadadadaddad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "3f67e0fd-50f2-4891-825f-f3902f46c1df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                column: "ConcurrencyStamp",
                value: "12192ec3-73e4-47e4-8fd2-d7292960966c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "4b3e637a-b792-460d-8d5e-d000f1c6bdd9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdasdasdasasasdadda", "85e64b9c-e6e5-4a68-8261-2247ddffa6d1", "DawaView", "DAWAVIEW" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9be39866-01ee-416a-b565-a05f252d3da8", "7ebd69d6-3bd8-4482-bb65-e13abd9c090f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "f2de626c-1795-4ddd-9598-d56ae7257098", "DawaView", "DawaView", "DAWAVIEW", "96f71130-a4b4-42e5-9567-4d65e30d4db2", "DawaView" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dASDadadasdasdasdsa", 0, "99c67519-f3f8-4d3f-afdd-00aacd4932cb", "owner", true, false, null, "owner", "OWNER", "000000", null, false, "4fd57a07-9cad-4383-9597-ba8aee0feef1", false, "owner" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "0569e7dc-2f7e-426b-8cdf-9c304fb254f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                column: "ConcurrencyStamp",
                value: "3eed811b-3ccd-4781-ab53-0cbb89f441ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "288b4a7d-0e4c-48ce-8c85-077380df5b0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b3bfb11-69c0-4092-99eb-ed9ced1bd39c", "0f9a561e-4f03-44f0-9985-f23f8bc10d06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "3ec1c0b1-1d07-4d72-9e5e-4702749d376e", "owner", "owner", "OWNER", "eb11492e-38d1-4460-b9a7-354d986c1e94", "owner" });
        }
    }
}
