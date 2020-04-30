using Microsoft.EntityFrameworkCore.Migrations;

namespace LawManagementSystem.Migrations
{
    public partial class caseEntityToCasesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_AspNetUsers_AppUserId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCase_Case_CaseId",
                table: "UserCase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Case",
                table: "Case");

            migrationBuilder.RenameTable(
                name: "Case",
                newName: "Cases");

            migrationBuilder.RenameIndex(
                name: "IX_Case_AppUserId",
                table: "Cases",
                newName: "IX_Cases_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cases",
                table: "Cases",
                column: "CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_AspNetUsers_AppUserId",
                table: "Cases",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCase_Cases_CaseId",
                table: "UserCase",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "CaseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_AspNetUsers_AppUserId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCase_Cases_CaseId",
                table: "UserCase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cases",
                table: "Cases");

            migrationBuilder.RenameTable(
                name: "Cases",
                newName: "Case");

            migrationBuilder.RenameIndex(
                name: "IX_Cases_AppUserId",
                table: "Case",
                newName: "IX_Case_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Case",
                table: "Case",
                column: "CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_AspNetUsers_AppUserId",
                table: "Case",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCase_Case_CaseId",
                table: "UserCase",
                column: "CaseId",
                principalTable: "Case",
                principalColumn: "CaseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
