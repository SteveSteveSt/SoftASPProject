using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoftUniGamesApp.Data.Models;

namespace SoftUniGamesApp.Data
{
    public class GamesDbContext : DbContext
    {
        public GamesDbContext()
        {
            
        }

        public GamesDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Game> Games { get; set; } = null!;
    }
}
