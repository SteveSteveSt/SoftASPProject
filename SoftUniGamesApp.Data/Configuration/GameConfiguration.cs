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
        }
    }
}
