using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsPortal.Context.Migrations
{
    public partial class NotNullSetForRoleID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemUsers_UserRolls_UserRollID",
                table: "SystemUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserRollID",
                table: "SystemUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemUsers_UserRolls_UserRollID",
                table: "SystemUsers",
                column: "UserRollID",
                principalTable: "UserRolls",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemUsers_UserRolls_UserRollID",
                table: "SystemUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserRollID",
                table: "SystemUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SystemUsers_UserRolls_UserRollID",
                table: "SystemUsers",
                column: "UserRollID",
                principalTable: "UserRolls",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
