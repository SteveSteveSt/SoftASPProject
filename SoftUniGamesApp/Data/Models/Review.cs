using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUniGamesApp.Data.Models
{
    public class Review
    {
        [Key]
        [Comment("Review Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)] //make constant
        [Comment("Review title")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(400)] //make constant
        [Comment("Review Content")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Writer Identifier")]
        public string WriterId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(WriterId))]
        public IdentityUser Writer { get; set; } = null!;

        [Required]
        [Comment("Writing date")]
        public DateTime AddedOn { get; set; }
    }
}
