using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTrashCollector.Data.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b793aacc-4e57-4994-80ae-6658a25cae68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49f28a15-776b-477f-be5b-117dedecaa53", "8f153042-f7b1-4cfc-b2b8-dea6b77f0173", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9881422-258b-4a6b-8f20-b473ed0b3cb3", "7d54dbec-635d-45cb-8152-66ff95038790", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f28a15-776b-477f-be5b-117dedecaa53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9881422-258b-4a6b-8f20-b473ed0b3cb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b793aacc-4e57-4994-80ae-6658a25cae68", "27c48393-17fa-4c58-9854-85e670bdbed7", "Admin", "ADMIN" });
        }
    }
}
