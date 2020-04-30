using Microsoft.EntityFrameworkCore.Migrations;

namespace LawManagementSystem.Migrations
{
    public partial class inUserCaseEntityDatatypeOfAppUserIdChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCase_AspNetUsers_UserId",
                table: "UserCase");

            migrationBuilder.DropIndex(
                name: "IX_UserCase_UserId",
                table: "UserCase");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserCase");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "UserCase",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Case",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserCase_AppUserId",
                table: "UserCase",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCase_AspNetUsers_AppUserId",
                table: "UserCase",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCase_AspNetUsers_AppUserId",
                table: "UserCase");

            migrationBuilder.DropIndex(
                name: "IX_UserCase_AppUserId",
                table: "UserCase");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "UserCase",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserCase",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Case",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_UserCase_UserId",
                table: "UserCase",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCase_AspNetUsers_UserId",
                table: "UserCase",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
