using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftUniGamesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1208e489-d61d-4a96-833c-afe43d73afa9"));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "ReleaseDate", "Studio", "Title" },
                values: new object[] { new Guid("d388bcb8-dbea-416f-8b77-6141f01f7a20"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d388bcb8-dbea-416f-8b77-6141f01f7a20"));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "ReleaseDate", "Studio", "Title" },
                values: new object[] { new Guid("1208e489-d61d-4a96-833c-afe43d73afa9"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" });
        }
    }
}
