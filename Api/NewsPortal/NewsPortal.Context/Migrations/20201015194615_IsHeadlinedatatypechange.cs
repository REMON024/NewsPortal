using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Context.Migrations
{
    public partial class IsHeadlinedatatypechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isHeadline",
                table: "Feeds",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "isHeadline",
                table: "Feeds",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
