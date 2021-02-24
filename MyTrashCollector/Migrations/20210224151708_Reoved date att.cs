using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTrashCollector.Migrations
{
    public partial class Reoveddateatt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4569b923-f325-4b5f-b67d-f25d1d5720d4", "f4c9258f-1b07-40ea-8616-4d7e5d45e32a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a84e42d9-a385-447e-90ff-78becd422455", "71a720ad-0e1b-4914-a36d-03b5db614647", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4569b923-f325-4b5f-b67d-f25d1d5720d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a84e42d9-a385-447e-90ff-78becd422455");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c35ba80-f192-40be-9fd9-691c4c31a8cd", "0feee008-6849-43de-bd2a-583e2962ae0e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd339a75-664e-434a-aac7-dc7d7da8928e", "31a73984-794f-4eef-96f7-260ba8110516", "Employee", "EMPLOYEE" });
        }
    }
}
