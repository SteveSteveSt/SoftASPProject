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
                    Genre = "Card Game",
                    ReleaseDate = new DateTime(2024, 12, 06),
                    LastUpdate = new DateTime(2024, 12, 14),
                    Studio = "Gambo Games"
                }
            };

            return seedGames;
        }
    }
}
