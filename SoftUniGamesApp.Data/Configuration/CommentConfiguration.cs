using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftUniGamesApp.Data.Models;
using static SoftUniGamesApp.Common.EntityValidationConstants.Comment;

namespace SoftUniGamesApp.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Message).IsRequired().HasMaxLength(MessageMaxLength);

            builder.HasOne(c => c.Game).WithMany(g => g.Comments).HasForeignKey(c => c.GameId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
