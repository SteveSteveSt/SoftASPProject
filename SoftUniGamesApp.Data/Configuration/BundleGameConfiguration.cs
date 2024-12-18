using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftUniGamesApp.Data.Models;

namespace SoftUniGamesApp.Data.Configuration
{
    public class BundleGameConfiguration : IEntityTypeConfiguration<BundleGame>
    {
        public void Configure(EntityTypeBuilder<BundleGame> builder)
        {
            builder.HasKey(bg => new { bg.GameId, bg.BundleId });

            builder
                .HasOne(bg => bg.Game)
                .WithMany(g => g.BundlesGames)
                .HasForeignKey(bg => bg.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(bg => bg.Bundle)
                .WithMany(b => b.BundlesGames)
                .HasForeignKey(bg => bg.BundleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
