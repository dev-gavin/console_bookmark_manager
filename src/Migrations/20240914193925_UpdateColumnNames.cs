using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookmarkManager.Migrations
{
    /// <inheritdoc />
    public partial class UpdateColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Bookmarks_BookmarkId",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tags",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "BookmarkId",
                table: "Tags",
                newName: "bookmarkid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_BookmarkId",
                table: "Tags",
                newName: "IX_Tags_bookmarkid");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Bookmarks",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Bookmarks",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookmarks",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Bookmarks_bookmarkid",
                table: "Tags",
                column: "bookmarkid",
                principalTable: "Bookmarks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Bookmarks_bookmarkid",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tags",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "bookmarkid",
                table: "Tags",
                newName: "BookmarkId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_bookmarkid",
                table: "Tags",
                newName: "IX_Tags_BookmarkId");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Bookmarks",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Bookmarks",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bookmarks",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Bookmarks_BookmarkId",
                table: "Tags",
                column: "BookmarkId",
                principalTable: "Bookmarks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
