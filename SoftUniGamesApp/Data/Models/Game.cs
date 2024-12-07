using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SoftUniGamesApp.Data.Models
{
    public class Game
    {
        [Key]
        [Comment("Game Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] //make constant
        [Comment("Game name")]
        public string Name { get; set; } = string.Empty;
    }
}
