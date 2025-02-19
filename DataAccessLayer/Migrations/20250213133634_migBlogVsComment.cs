using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migBlogVsComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comments_BlogId",
                table: "comments",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments");

            migrationBuilder.DropIndex(
                name: "IX_comments_BlogId",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "comments");
        }
    }
}
