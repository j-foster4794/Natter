using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Natter.Migrations
{
    /// <inheritdoc />
    public partial class RemovinginteractionIdfromthenatterpostsdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NatterPosts_NatterInteractions_NatterInteractionId",
                table: "NatterPosts");

            migrationBuilder.DropIndex(
                name: "IX_NatterPosts_NatterInteractionId",
                table: "NatterPosts");

            migrationBuilder.DropColumn(
                name: "NatterInteractionId",
                table: "NatterPosts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NatterInteractionId",
                table: "NatterPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NatterPosts_NatterInteractionId",
                table: "NatterPosts",
                column: "NatterInteractionId");

            migrationBuilder.AddForeignKey(
                name: "FK_NatterPosts_NatterInteractions_NatterInteractionId",
                table: "NatterPosts",
                column: "NatterInteractionId",
                principalTable: "NatterInteractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
