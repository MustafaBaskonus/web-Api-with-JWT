using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRoleForRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48984a82-c551-4d14-83e3-d7585baaab3d", "98dc741f-b248-49ad-9120-b38518326be6", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "934776b4-3caf-47f5-9944-b07e8dfcea78", "9a54cc96-80ee-4bab-8ac5-4a3c17864f79", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "deeb3f63-0b98-4de9-8471-c72d4c1c082b", "16addb48-e998-4604-ab54-5ce5e0e43550", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48984a82-c551-4d14-83e3-d7585baaab3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "934776b4-3caf-47f5-9944-b07e8dfcea78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deeb3f63-0b98-4de9-8471-c72d4c1c082b");
        }
    }
}
