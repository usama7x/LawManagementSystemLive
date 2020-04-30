using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LawManagementSystem.Migrations
{
    public partial class changeFieldFromNatureToTypeInEntityCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Case");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Case",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Case",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserCase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    CaseId = table.Column<int>(nullable: false),
                    Stamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCase_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "CaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCase_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCase_CaseId",
                table: "UserCase",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCase_UserId",
                table: "UserCase",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCase");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Case");

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Case",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nature",
                table: "Case",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
