using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftUniGamesApp.Data.Models;
using static SoftUniGamesApp.Common.EntityValidationConstants.Game;

namespace SoftUniGamesApp.Data.Configuration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Title).IsRequired().HasMaxLength(TitleMaxLength);
            builder.Property(g => g.Genre).IsRequired().HasMaxLength(GenreMaxLength);
            builder.Property(g => g.Studio).IsRequired().HasMaxLength(StudioMaxLength);
            builder.Property(g => g.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasData(this.SeedGames());
        }

        private List<Game> SeedGames()
        {
            List<Game> seedGames = new List<Game>()
            {
                new Game()
                {
                    Title = "Poker",
                    Description = "Experience our smooth, lightweight digital poker game",
                    Price = 8m,
                    Genre = "Card Game",
                    ReleaseDate = new DateTime(2024, 12, 06),
                    LastUpdate = new DateTime(2024, 12, 14),
                    Studio = "Gambo Games"
                },
                new Game()
                {
                    Title = "MonTrade",
                    Description = "Collect and trade them all, to fulfill your monster encyclopedia",
                    Price = 10m,
                    Genre = "Card Game",
                    ReleaseDate = new DateTime(2020, 05, 05),
                    LastUpdate = new DateTime(2021, 01, 09),
                    Studio = "Gambo Games"
                }
            };

            return seedGames;
        }
    }
}
