using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class sdasdadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "d218da75-285d-4123-b81c-e4691b4d44ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "a53b87cb-26e2-4972-954c-8e89606667de");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "df7cdcec-a792-40b3-8269-98209cba20c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "255a5e4b-2a92-4c93-a543-2f58bd50eefa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "asdasadadaddacsdadda", "d2e18640-219c-4e87-ac57-faee1d5f9245", "regulator", "REGULATOR" },
                    { "asdasdasasdadda", "a47b7be9-02d6-4807-8b81-eb08aa6b9169", "admin", "ADMIN" },
                    { "asdfadaczsdsdsdsdxcsfhdfd", "ee414c5b-7d87-4f0f-b9cf-51ad6e9140a5", "admin2", "ADMIN2" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65d6cf60-c4bd-4269-ac0b-ec8e8311027f", "cc95d6dc-4421-444a-9f0e-a64303f824e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07382265-1430-4b56-be87-183289e5965d", "222ac207-a4c4-45ba-88a7-7ae90c985b8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98ea9871-79d9-4e2c-8d36-272e14f658d8", "ef2efc21-8e0d-4637-a4a1-fb138661052b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasadadaddacsdadda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "f7b77f78-8f9f-4cdb-a8f7-492aaf18a0a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "ca7c4bab-2e48-44da-8d41-4f6b071bfc55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "6f56d95d-9d80-4477-80f0-591386fdd015");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "e155c8ec-7e35-4d89-962f-44d51524880a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "2caf90ab-51e5-41fc-933f-21c460694818", "admin", "ADMIN" },
                    { "admin2", "197e9d6e-3ad9-45c5-8f13-17e9e738a23b", "admin2", "ADMIN2" },
                    { "regulator", "328fb6ed-385c-41b1-9360-63414fbde5af", "regulator", "REGULATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "779930be-c8d1-4480-862a-3c46beebd0df", "00251fdb-e7a9-4b95-9a46-d7c0b56128ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b59a387-b629-439e-8750-0e48711265b8", "2fb18639-b36d-474b-b7b9-775514ef1a3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3301efc9-ad77-4a55-9df6-9d1d944b9629", "6045aaf1-1ccc-4c8a-bd28-0cd3322510f3" });
        }
    }
}
