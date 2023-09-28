using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinistryOfWarerResources.Data.Migrations
{
    public partial class asa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasadadaddacsdadda",
                column: "ConcurrencyStamp",
                value: "0185804d-6ecf-44c5-994a-ae402f6dbf32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "eabde860-38bc-4862-bf10-47be4f1593fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "19355b30-4d2a-42b2-bd42-ced75e373d55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "6e40ec98-a15b-44bb-b0de-b63812127626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "52aa4140-1320-4c74-baae-c46aa01a3d42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "9af125d4-e70c-4342-9733-1c33f817f1e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "SuperAdmin", "5a0511f0-736e-4975-b099-d3be1627a442", "SuperAdmin", "SUPERADMIN" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SuperAdmin");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasadadaddacsdadda",
                column: "ConcurrencyStamp",
                value: "43b3a139-9e5a-41f8-bf30-613f2cdeda9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasasdadda",
                column: "ConcurrencyStamp",
                value: "d2e57aea-120f-4b21-8d15-76ecd924011f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdasdasdasasasdadda",
                column: "ConcurrencyStamp",
                value: "ce0d0a1a-f747-42ef-9aec-f6ab9b3d34fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczsdsdsdsdxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "bdbd9429-ac3e-468d-a51b-30532bb96678");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "asdfadaczxcsfhdfd",
                column: "ConcurrencyStamp",
                value: "c3b388d1-8577-41cc-9ede-dcb327faab9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "oi2eoij-1oqjsdkj-kaslk-OwnerRole",
                column: "ConcurrencyStamp",
                value: "21f50aa1-0eff-4ed0-8529-20c13e6c4395");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be4ae894-c4a4-4130-b398-1d5c4037053b", "452e8ac0-5044-4cd8-892e-173f3f445fb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cvfgrtbvdscvfd",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c495387f-920d-4e05-9ea3-bfc7aa9cc020", "70a6ba2b-d697-423c-a37f-d190bf3bc47d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dASDadadasdasdasdsa",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09ed730e-5a8d-4cd2-a497-08d421f0ff5f", "83f3c182-581b-4d46-afd3-351409cfd371" });
        }
    }
}
