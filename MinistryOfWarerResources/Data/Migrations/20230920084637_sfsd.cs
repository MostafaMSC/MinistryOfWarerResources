using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class sfsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "6d030614-3543-4fac-af76-f9131c1287cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "58be0e08-6fac-49fd-9774-6b7b64b628cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "2da0b972-c97d-4ce9-832d-23596cb914bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "1ef85120-755c-4752-b66c-d9db26641052");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "8c88e40b-77a1-492b-9ec6-c8ac990a8fc2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdasadadaddacsdadda", "2e537ffe-6c9e-43c0-aad1-ae6e1d03a9b8", "regulator", "REGULATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc1580ac-9728-42aa-96ba-06cc3d51f26b", "8193b80b-74e2-4a99-98d4-6b70ac6a106b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd6a95a8-f312-4533-9d17-a06076d71f8f", "bf3ed04c-b5b7-4e29-8f80-67a8b6441bb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de5f101a-c99e-4266-b021-46c546f95879", "6ecb2aeb-f548-42b8-9538-82e9b7739c68" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasadadaddacsdadda");

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
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "381f5e6f-95ba-46d1-adb2-ef7dbe12d9d6");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f39c5f38-68b8-47c6-a7e1-06fae6301fe5", "530073a0-d345-44f1-9e2d-bd2ec938d86f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88ee0265-b5fe-49fc-b93e-aaa1fef2afe1", "40217d85-69c8-4e26-a12e-fc268eefad6c" });
        }
    }
}
