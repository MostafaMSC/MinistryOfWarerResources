using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class sdasda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "asdasdasdasasasdadda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd");

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
                    { "DawaView", "f7b77f78-8f9f-4cdb-a8f7-492aaf18a0a2", "DawaView", "DAWAVIEW" },
                    { "eatalaJazaea", "ca7c4bab-2e48-44da-8d41-4f6b071bfc55", "eatalaJazaea", "EATALAJAZAEA" },
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "DawaView");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "9af125d4-e70c-4342-9733-1c33f817f1e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "5a0511f0-736e-4975-b099-d3be1627a442");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "asdasadadaddacsdadda", "0185804d-6ecf-44c5-994a-ae402f6dbf32", "regulator", "REGULATOR" },
                    { "asdasdasasdadda", "eabde860-38bc-4862-bf10-47be4f1593fc", "admin", "ADMIN" },
                    { "asdasdasdasasasdadda", "19355b30-4d2a-42b2-bd42-ced75e373d55", "DawaView", "DAWAVIEW" },
                    { "asdfadaczsdsdsdsdxcsfhdfd", "6e40ec98-a15b-44bb-b0de-b63812127626", "admin2", "ADMIN2" },
                    { "asdfadaczxcsfhdfd", "52aa4140-1320-4c74-baae-c46aa01a3d42", "eatalaJazaea", "EATALAJAZAEA" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81e89d6b-1f30-4168-967e-1d55f9eca3ba", "6580177b-e6ea-4ab6-8b3d-ba427383f12a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f629a2c-6b7c-45bb-b484-fe86d40b273c", "7b077408-e4ef-4a8d-8482-1923d56ff154" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "140a39c0-035f-46db-85dc-e175dcfb1c8f", "1fef9149-4f68-4659-b85d-8e612907459e" });
        }
    }
}
