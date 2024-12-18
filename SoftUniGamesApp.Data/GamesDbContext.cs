using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftUniGamesApp.Data.Models;

namespace SoftUniGamesApp.Data
{
    public class GamesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public GamesDbContext()
        {
            
        }

        public GamesDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Bundle> Bundles { get; set; } = null!;
        public virtual DbSet<BundleGame> BundlesGames { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
