using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Novels.Migrations
{
    public partial class startup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreOfNovel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Novel",
                columns: table => new
                {
                    NovelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Review = table.Column<DateTime>(nullable: false),
                    IsFamous = table.Column<bool>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novel", x => x.NovelId);
                    table.ForeignKey(
                        name: "FK_Novel_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    NovelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_Author_Novel_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novel",
                        principalColumn: "NovelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NovelAuthor",
                columns: table => new
                {
                    NovelAuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(nullable: false),
                    NovelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovelAuthor", x => x.NovelAuthorId);
                    table.ForeignKey(
                        name: "FK_NovelAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NovelAuthor_Novel_NovelId",
                        column: x => x.NovelId,
                        principalTable: "Novel",
                        principalColumn: "NovelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_NovelId",
                table: "Author",
                column: "NovelId");

            migrationBuilder.CreateIndex(
                name: "IX_Novel_GenreId",
                table: "Novel",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_NovelAuthor_AuthorId",
                table: "NovelAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NovelAuthor_NovelId",
                table: "NovelAuthor",
                column: "NovelId");
            var sqlFile = Path.Combine(".\\MyNovelsSchemaAndData", @"MyNovels.sql");

            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NovelAuthor");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Novel");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
