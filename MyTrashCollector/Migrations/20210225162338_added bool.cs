using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTrashCollector.Migrations
{
    public partial class addedbool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236792e5-3975-4ead-a1a8-bec2119d4250");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caeaaa85-a2d9-4514-8d3e-b077afb76584");

            migrationBuilder.AddColumn<bool>(
                name: "CompletedPickup",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d35b7b9-61b2-4402-8db2-a1e874b74f0f", "c0367be5-1239-4759-8883-797be0213251", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f64641d0-1bd5-4d23-b6cc-4b88b420390a", "013592da-9cd4-4117-8429-d538ea3020f3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d35b7b9-61b2-4402-8db2-a1e874b74f0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64641d0-1bd5-4d23-b6cc-4b88b420390a");

            migrationBuilder.DropColumn(
                name: "CompletedPickup",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "236792e5-3975-4ead-a1a8-bec2119d4250", "debdaa6b-db7e-44f2-a3e2-aa64a886e77e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caeaaa85-a2d9-4514-8d3e-b077afb76584", "1f24c168-dec5-4c80-821a-5312dfe0f770", "Employee", "EMPLOYEE" });
        }
    }
}
