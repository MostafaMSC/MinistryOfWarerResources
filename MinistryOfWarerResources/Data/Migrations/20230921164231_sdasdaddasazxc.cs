using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class sdasdaddasazxc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "d34ae80b-e182-4c77-b220-744ecc89de68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "b815a732-5b44-44b8-915b-78ee8653a991");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "DawaView",
                column: "ConcurrencyStamp",
                value: "53ca7996-b4eb-433e-9433-f73c04684f25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eatalaJazaea",
                column: "ConcurrencyStamp",
                value: "b81c6677-0647-488a-a1fe-aecf001f3eb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "de8156c3-c948-4812-bcb8-1b3138f4c257");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "e33a2f59-c33f-442f-b97b-bd85bb572789");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "13eae850-19ad-4f94-bab3-7d1de9cb95fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d56ff8a0-18ce-4ff7-a3de-53c4b58463ac", "4f8bd8b3-aefa-4293-b2a4-614e3ce4b8aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a322b65-5e79-4f07-8a84-ea0ded329cec", "578970e5-4e8b-4669-8d5d-d0fa0f7b47e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "182122db-b296-468c-9b08-1224f2b4a368", "28eb6498-62e9-4db2-8bc2-62fb58ae831f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin",
                column: "ConcurrencyStamp",
                value: "c3468552-ea71-43c8-8459-9e6cbf6a370b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin2",
                column: "ConcurrencyStamp",
                value: "82bfe1fd-da4b-4dac-a33d-61e4a933419d");

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
                keyValue: "owner",
                column: "ConcurrencyStamp",
                value: "fb8289f2-d5b7-4b2a-a7ac-72412c01be1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "regulator",
                column: "ConcurrencyStamp",
                value: "c7ceb4a0-de21-4caf-90a9-8784f302eddb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin",
                column: "ConcurrencyStamp",
                value: "e834b475-2721-4afb-a74a-2132c6c8b81f");

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
    }
}
