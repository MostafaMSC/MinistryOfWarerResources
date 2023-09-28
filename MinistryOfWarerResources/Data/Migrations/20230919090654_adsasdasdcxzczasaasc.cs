using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class adsasdasdcxzczasaasc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "asdasdasdasdadaasdascvcxvdfgddad",
                column: "ConcurrencyStamp",
                value: "35b46295-246d-4d1d-94a6-7f4034a45b31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "50f67f0a-3af5-491e-aa84-e9e690b27014");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "asdfadaczxcsfhdfd", "cef62bb8-5149-47e1-bd7e-5497c30e9a65", "eatalaJazaea", "EATALAJAZAEA" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "a5289e49-c7f2-4171-b6c8-dbb62862d155");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "9f791be4-7720-44ee-9b48-ba857a21d824");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdascvcxvdfgddad",
                column: "ConcurrencyStamp",
                value: "55579a6b-200b-410e-aa2f-4326ee321b6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "83ff1352-7582-410a-add7-1ec447107e2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a81ee15-dea6-4f15-8cc4-70060c05c9a0", "72c0a4eb-2e90-4c3c-b930-e168f6ab82a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58eb64fd-4aad-4a3d-b4c0-04b28d728482", "0432d28e-576f-4422-8e8b-757e8d91f377" });
        }
    }
}
