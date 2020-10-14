using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Context.Migrations
{
    public partial class addroleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserRolls",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Reader" });

            migrationBuilder.InsertData(
                table: "UserRolls",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRolls",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRolls",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
