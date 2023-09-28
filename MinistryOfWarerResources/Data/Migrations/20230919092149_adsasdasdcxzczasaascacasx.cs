using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class adsasdasdcxzczasaascacasx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdascvcxvdfgddad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "d05e1a17-f3ae-40e8-b322-96c6ba35ad49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "8c7d079c-4509-427f-b175-93130d51f3e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "bebb1a7c-33d4-41d1-9236-072568476047");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "d378a6ed-230c-4fde-b9ec-b700d1317677");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b160a983-dcfe-4b48-b59a-2c68a5355a93", "1c5a3dcf-b088-489c-938a-37edc1ec47fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdb2d843-e6a6-4373-b6b0-86fc036a7e14", "fdcc357e-7cff-4f47-9c69-ef4b2c0b99b1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cvfgrtbvdscvfd", 0, "bd668afc-9d54-419c-8086-0c68bc352b11", "admin", true, false, null, "admin", "admin2", "000000", null, false, "31ad4e7d-ff93-4c5e-b45d-65f6aee882f5", false, "admin2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "eeaf9651-6a8f-4d76-92c4-186be9993947");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "597f3515-525e-4219-b177-0b5bb7910843");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "cef62bb8-5149-47e1-bd7e-5497c30e9a65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "50f67f0a-3af5-491e-aa84-e9e690b27014");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdasdasdasdadaasdascvcxvdfgddad", "35b46295-246d-4d1d-94a6-7f4034a45b31", "JazaeaView", "JAZEAVIEW" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64089691-7395-4c65-bfab-31899629f340", "887c6e99-cada-4c28-8023-152d25283c63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "820be61a-3761-4650-b3a0-d876240d3624", "b5c4212c-b4d9-41e7-af06-f502eefc0f1d" });
        }
    }
}
