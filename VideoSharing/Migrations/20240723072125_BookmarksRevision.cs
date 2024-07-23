using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoSharing.Migrations
{
    /// <inheritdoc />
    public partial class BookmarksRevision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bookmarks",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int[]>(
                name: "Bookmarks",
                table: "Users",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);
        }
    }
}
