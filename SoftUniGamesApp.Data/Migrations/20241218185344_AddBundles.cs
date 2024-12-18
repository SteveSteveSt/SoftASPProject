using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftUniGamesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBundles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d388bcb8-dbea-416f-8b77-6141f01f7a20"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Games",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Bundles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bundles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BundlesGames",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BundleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BundlesGames", x => new { x.GameId, x.BundleId });
                    table.ForeignKey(
                        name: "FK_BundlesGames_Bundles_BundleId",
                        column: x => x.BundleId,
                        principalTable: "Bundles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BundlesGames_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Bundles",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("54836130-d26d-4679-9ca9-63550d76836e"), "Pair Gamble", 12.80m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "Price", "ReleaseDate", "Studio", "Title" },
                values: new object[,]
                {
                    { new Guid("1f6c2b46-5ffd-43d8-bfc1-3f5d70e3162a"), "Collect and trade them all, to fulfill your monster encyclopedia", "Card Game", new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "MonTrade" },
                    { new Guid("6da8773d-6a10-4774-aaeb-d8dadf9e0de3"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BundlesGames_BundleId",
                table: "BundlesGames",
                column: "BundleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BundlesGames");

            migrationBuilder.DropTable(
                name: "Bundles");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1f6c2b46-5ffd-43d8-bfc1-3f5d70e3162a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6da8773d-6a10-4774-aaeb-d8dadf9e0de3"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Games");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "ReleaseDate", "Studio", "Title" },
                values: new object[] { new Guid("d388bcb8-dbea-416f-8b77-6141f01f7a20"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" });
        }
    }
}
