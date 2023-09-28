using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class adsasdasdcxzczasaascacasxadda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "d4244eba-fe9a-4557-bd02-1072543f98d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "cc7d9eab-fd4f-468c-a72a-121ad79cdddb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "4ede2498-7c42-44a2-989a-3b2c431246ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "e36863a0-74cd-47cb-af51-11abbe108e8b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdfadaczsdsdsdsdxcsfhdfd", "381f5e6f-95ba-46d1-adb2-ef7dbe12d9d6", "admin2", "ADMIN2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0b81551-d9ce-4681-8efd-8d1066330a9d", "804b42a3-a31f-4d3c-9af9-f6dcbaff994a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "f39c5f38-68b8-47c6-a7e1-06fae6301fe5", "ADMIN2", "530073a0-d345-44f1-9e2d-bd2ec938d86f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88ee0265-b5fe-49fc-b93e-aaa1fef2afe1", "40217d85-69c8-4e26-a12e-fc268eefad6c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd");

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
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "bd668afc-9d54-419c-8086-0c68bc352b11", "admin2", "31ad4e7d-ff93-4c5e-b45d-65f6aee882f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdb2d843-e6a6-4373-b6b0-86fc036a7e14", "fdcc357e-7cff-4f47-9c69-ef4b2c0b99b1" });
        }
    }
}
