using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class adsaasdsaasas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "4686794d-ff6f-4470-a033-6788867e72db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "53a1ee06-d8f3-4a6b-bcb1-73b4a418c857");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12e52cea-afbb-4d54-b10b-f48cfc515ff5", "JazaeaView", "JAZEAVIEW" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "225fca61-c9c2-47ad-be30-df0095396abe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36cbf324-51f4-4d9c-8c5b-3c3a8a7b5070", "83cf12f7-33c2-41cf-88f7-392628fbe726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1439f228-6e4c-41b0-b265-67f102598c9d", "93813e47-a357-41a3-b090-d28a34a18f6c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "a82d7a06-3163-4c31-b67c-ca1eddfbb6ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "11c73b11-f8cc-4df4-b986-2a4f9c6b0b26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "641f1d7c-13ca-4af3-abec-97c562a1fe40", "DawaUser", "DAWAUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "d446e925-29f7-49ec-b433-e780b8877b22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "286b8ea5-cdd6-42bd-bb4a-09e44d072a77", "28e6d965-4ffc-449e-86ad-2922ad9d8c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6303d4a-4402-4119-bce9-f02ee657fd52", "b84159d2-8a30-4164-bf54-a63ab3d6073e" });
        }
    }
}
