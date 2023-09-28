using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class sdasdaddasa : Migration
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
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "a596fd11-1864-4cc5-9621-5490e68a2721");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "f9d0a9bf-f7ea-41ab-9a25-bb35cece725e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "e834b475-2721-4afb-a74a-2132c6c8b81f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin", "c3468552-ea71-43c8-8459-9e6cbf6a370b", "admin", "ADMIN" },
                    { "admin2", "82bfe1fd-da4b-4dac-a33d-61e4a933419d", "admin2", "ADMIN2" },
                    { "owner", "fb8289f2-d5b7-4b2a-a7ac-72412c01be1b", "owner", "OWNER" },
                    { "regulator", "c7ceb4a0-de21-4caf-90a9-8784f302eddb", "regulator", "REGULATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24b24c73-ce37-4801-834e-bd2daa794aa3", "e79fb03b-75dc-47ec-b6c5-a967837c4124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0eae4e86-d246-498c-9c68-49c91acffd9d", "aab4157c-e65b-415e-a4e0-44cf4ea71573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d11a2879-c631-4b0c-b51d-f88b45c4067f", "7c0cf504-760b-438f-8f4d-778b47b2850c" });
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
                keyValue: "owner");

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
                    { "asdfadaczsdsdsdsdxcsfhdfd", "ee414c5b-7d87-4f0f-b9cf-51ad6e9140a5", "admin2", "ADMIN2" },
                    { "oi2eoij-1oqjsdkj-kaslk-OwnerRole", "df7cdcec-a792-40b3-8269-98209cba20c7", "owner", "OWNER" }
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
    }
}
