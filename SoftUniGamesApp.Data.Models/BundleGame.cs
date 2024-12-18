using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniGamesApp.Data.Models
{
    public class BundleGame
    {
        public Guid GameId { get; set; }

        public virtual Game Game { get; set; } = null!;

        public Guid BundleId { get; set; }

        public virtual Bundle Bundle { get; set; } = null!;
    }
}
