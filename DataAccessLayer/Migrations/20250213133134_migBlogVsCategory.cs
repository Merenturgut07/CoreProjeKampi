using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migBlogVsCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CategoryId",
                table: "blogs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_CategoryId",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "blogs");
        }
    }
}
