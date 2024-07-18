using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Natter.Migrations
{
    /// <inheritdoc />
    public partial class AddRemainingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NatterInteractionId",
                table: "NatterPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NatterInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NatterUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatterInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatterInteractions_NatterUsers_NatterUserId",
                        column: x => x.NatterUserId,
                        principalTable: "NatterUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NatterMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatterMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NatterPostsInteractions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NatterPostId = table.Column<int>(type: "int", nullable: false),
                    NatterInteractionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatterPostsInteractions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatterPostsInteractions_NatterInteractions_NatterInteractionId",
                        column: x => x.NatterInteractionId,
                        principalTable: "NatterInteractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NatterPostsInteractions_NatterPosts_NatterPostId",
                        column: x => x.NatterPostId,
                        principalTable: "NatterPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NatterUserMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SentFromUserId = table.Column<int>(type: "int", nullable: false),
                    NatterMessageId = table.Column<int>(type: "int", nullable: false),
                    SentToUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatterUserMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NatterUserMessages_NatterMessages_NatterMessageId",
                        column: x => x.NatterMessageId,
                        principalTable: "NatterMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NatterUserMessages_NatterUsers_SentFromUserId",
                        column: x => x.SentFromUserId,
                        principalTable: "NatterUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NatterUserMessages_NatterUsers_SentToUserId",
                        column: x => x.SentToUserId,
                        principalTable: "NatterUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NatterPosts_NatterInteractionId",
                table: "NatterPosts",
                column: "NatterInteractionId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterInteractions_NatterUserId",
                table: "NatterInteractions",
                column: "NatterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterPostsInteractions_NatterInteractionId",
                table: "NatterPostsInteractions",
                column: "NatterInteractionId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterPostsInteractions_NatterPostId",
                table: "NatterPostsInteractions",
                column: "NatterPostId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterUserMessages_NatterMessageId",
                table: "NatterUserMessages",
                column: "NatterMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterUserMessages_SentFromUserId",
                table: "NatterUserMessages",
                column: "SentFromUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NatterUserMessages_SentToUserId",
                table: "NatterUserMessages",
                column: "SentToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_NatterPosts_NatterInteractions_NatterInteractionId",
                table: "NatterPosts",
                column: "NatterInteractionId",
                principalTable: "NatterInteractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NatterPosts_NatterInteractions_NatterInteractionId",
                table: "NatterPosts");

            migrationBuilder.DropTable(
                name: "NatterPostsInteractions");

            migrationBuilder.DropTable(
                name: "NatterUserMessages");

            migrationBuilder.DropTable(
                name: "NatterInteractions");

            migrationBuilder.DropTable(
                name: "NatterMessages");

            migrationBuilder.DropIndex(
                name: "IX_NatterPosts_NatterInteractionId",
                table: "NatterPosts");

            migrationBuilder.DropColumn(
                name: "NatterInteractionId",
                table: "NatterPosts");
        }
    }
}
