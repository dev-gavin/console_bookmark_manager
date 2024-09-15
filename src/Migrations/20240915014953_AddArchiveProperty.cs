using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookmarkManager.Migrations
{
    /// <inheritdoc />
    public partial class AddArchiveProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Bookmarks_bookmarkid",
                table: "Tags");

            migrationBuilder.RenameColumn(
                name: "bookmarkid",
                table: "Tags",
                newName: "BookmarkId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_bookmarkid",
                table: "Tags",
                newName: "IX_Tags_BookmarkId");

            migrationBuilder.AddColumn<bool>(
                name: "isArchived",
                table: "Bookmarks",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Bookmarks_BookmarkId",
                table: "Tags",
                column: "BookmarkId",
                principalTable: "Bookmarks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Bookmarks_BookmarkId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "isArchived",
                table: "Bookmarks");

            migrationBuilder.RenameColumn(
                name: "BookmarkId",
                table: "Tags",
                newName: "bookmarkid");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_BookmarkId",
                table: "Tags",
                newName: "IX_Tags_bookmarkid");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Bookmarks_bookmarkid",
                table: "Tags",
                column: "bookmarkid",
                principalTable: "Bookmarks",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
