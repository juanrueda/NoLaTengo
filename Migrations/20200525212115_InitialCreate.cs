using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NoLaTengo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementName = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    Finished = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PagesNumber = table.Column<int>(nullable: false),
                    Publisher = table.Column<string>(nullable: true),
                    ElementCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Libros_Categories_ElementCategoryId",
                        column: x => x.ElementCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementName = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    Finished = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Duration = table.Column<DateTime>(nullable: false),
                    ElementCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Categories_ElementCategoryId",
                        column: x => x.ElementCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_ElementCategoryId",
                table: "Libros",
                column: "ElementCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_ElementCategoryId",
                table: "Peliculas",
                column: "ElementCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
