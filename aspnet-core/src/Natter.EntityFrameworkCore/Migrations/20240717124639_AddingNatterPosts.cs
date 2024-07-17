using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Natter.Migrations
{
    /// <inheritdoc />
    public partial class AddingNatterPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NatterPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatterUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatterPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatterPosts_NatterUsers_NatterUserId",
                        column: x => x.NatterUserId,
                        principalTable: "NatterUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NatterPosts_NatterUserId",
                table: "NatterPosts",
                column: "NatterUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NatterPosts");
        }
    }
}
