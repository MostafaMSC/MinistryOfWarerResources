using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class asdasaadadadadad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ec1c0b1-1d07-4d72-9e5e-4702749d376e", "eb11492e-38d1-4460-b9a7-354d986c1e94" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "77b050fc-b52f-425f-9e63-9ec89058f642");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasdadaasdasdasdad",
                column: "ConcurrencyStamp",
                value: "09e7acdc-4afa-484c-b275-d68992c91312");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "9d414771-2fec-4c7f-acd0-dccbb1d9ba2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d39c993-fe15-46fc-904c-b583a670b2a3", "2f5a6dc9-3a00-45a6-ac9a-f1fcc609b243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68bbccee-69e0-4b49-921c-8b093c6b7161", "facf0a7a-a787-4293-9c58-f1f6c792ed25" });
        }
    }
}
