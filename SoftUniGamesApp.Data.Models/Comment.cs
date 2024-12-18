using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniGamesApp.Data.Models
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Message { get; set; } = null!;

        public DateTime CommentDate { get; set; }

        public Guid GameId { get; set; }

        public virtual Game Game { get; set; } = null!;

        public virtual ICollection<ApplicationUser> LikedUsers { get; set; } = new HashSet<ApplicationUser>();
    }
}
