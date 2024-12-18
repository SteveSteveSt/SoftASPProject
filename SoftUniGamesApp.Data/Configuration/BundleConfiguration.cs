using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftUniGamesApp.Data.Models;
using static SoftUniGamesApp.Common.EntityValidationConstants.Bundle;

namespace SoftUniGamesApp.Data.Configuration
{
    public class BundleConfiguration : IEntityTypeConfiguration<Bundle>
    {
        public void Configure(EntityTypeBuilder<Bundle> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name).IsRequired().HasMaxLength(NameMaxLength);
            builder.Property(b => b.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.HasData(this.GenerateBundles());
        }

        private IEnumerable<Bundle> GenerateBundles()
        {
            IEnumerable<Bundle> bundles = new List<Bundle>()
            {
                new Bundle()
                {
                    Name = "Pair Gamble",
                    Price = 12.80m
                }
            };

            return bundles;
        }
    }
}
