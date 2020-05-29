using Microsoft.EntityFrameworkCore.Migrations;

namespace NoLaTengo.Migrations
{
    public partial class CategoryIdAtributte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_ElementCategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_ElementCategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ElementCategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Books_ElementCategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ElementCategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ElementCategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "ElementCategoryId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementCategoryId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ElementCategoryId",
                table: "Movies",
                column: "ElementCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ElementCategoryId",
                table: "Books",
                column: "ElementCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_ElementCategoryId",
                table: "Books",
                column: "ElementCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_ElementCategoryId",
                table: "Movies",
                column: "ElementCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
