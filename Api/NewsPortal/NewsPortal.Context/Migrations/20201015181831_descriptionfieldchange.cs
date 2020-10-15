using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Context.Migrations
{
    public partial class descriptionfieldchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Feeds",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Feeds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
