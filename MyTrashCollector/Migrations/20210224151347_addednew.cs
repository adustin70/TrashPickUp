using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTrashCollector.Migrations
{
    public partial class addednew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7475d7a7-d106-4326-850c-5e8ea10bc9ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4970038-ee0b-4d9a-b76a-741ad5cef13b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c35ba80-f192-40be-9fd9-691c4c31a8cd", "0feee008-6849-43de-bd2a-583e2962ae0e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd339a75-664e-434a-aac7-dc7d7da8928e", "31a73984-794f-4eef-96f7-260ba8110516", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c35ba80-f192-40be-9fd9-691c4c31a8cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd339a75-664e-434a-aac7-dc7d7da8928e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7475d7a7-d106-4326-850c-5e8ea10bc9ec", "6fb3b007-aabe-466d-92ef-98f3103dafc8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4970038-ee0b-4d9a-b76a-741ad5cef13b", "b7ba360e-f10d-4460-b7a0-4996cf7e3a8b", "Employee", "EMPLOYEE" });
        }
    }
}
