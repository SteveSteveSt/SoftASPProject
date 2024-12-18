using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftUniGamesApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bundles",
                keyColumn: "Id",
                keyValue: new Guid("c9ec49f0-c0f9-48ba-83e7-c29c1aea0dc6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5083def5-5d00-4134-bfa3-af949c098864"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("daff47d7-c351-4c51-a037-facd25773491"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<Guid>(
                name: "CommentId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Bundles",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("60a03a8e-f79d-45aa-8eb5-26a0d9c8c99a"), "Pair Gamble", 12.80m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "Price", "ReleaseDate", "Studio", "Title" },
                values: new object[,]
                {
                    { new Guid("0eb6c030-911c-4c83-8a6c-3057cb8eb77d"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" },
                    { new Guid("c662a05a-e63e-4a9c-a5e1-bb5619748285"), "Collect and trade them all, to fulfill your monster encyclopedia", "Card Game", new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "MonTrade" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CommentId",
                table: "AspNetUsers",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_GameId",
                table: "Comments",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Comments_CommentId",
                table: "AspNetUsers",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Comments_CommentId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CommentId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Bundles",
                keyColumn: "Id",
                keyValue: new Guid("60a03a8e-f79d-45aa-8eb5-26a0d9c8c99a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0eb6c030-911c-4c83-8a6c-3057cb8eb77d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c662a05a-e63e-4a9c-a5e1-bb5619748285"));

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Bundles",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("c9ec49f0-c0f9-48ba-83e7-c29c1aea0dc6"), "Pair Gamble", 12.80m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Genre", "LastUpdate", "Price", "ReleaseDate", "Studio", "Title" },
                values: new object[,]
                {
                    { new Guid("5083def5-5d00-4134-bfa3-af949c098864"), "Experience our smooth, lightweight digital poker game", "Card Game", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8m, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "Poker" },
                    { new Guid("daff47d7-c351-4c51-a037-facd25773491"), "Collect and trade them all, to fulfill your monster encyclopedia", "Card Game", new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gambo Games", "MonTrade" }
                });
        }
    }
}
