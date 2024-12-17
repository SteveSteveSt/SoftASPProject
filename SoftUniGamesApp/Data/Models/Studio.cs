using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUniGamesApp.Data.Models
{
    public class Studio
    {
        /*
        [Key]
        [Comment("Game Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)] //make constant
        [Comment("Game name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(250)] //make constant
        [Comment("Game description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Precision(6,2)]
        [Comment("How much the game costs")]
        public decimal Price {  get; set; } //1.00m to 1800.00m or less

        [Required]
        [Comment("Status of release")]
        public string Release { get; set; } = string.Empty; //unreleased, early access, finished

        [Comment("Link to download mirror")]
        public string DownloadUrl { get; set; }

        [Required]
        [Comment("Developer Identifier")]
        public string DeveloperId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(DeveloperId))]
        public IdentityUser Developer { get; set; } = null!;

        [Required]
        [Comment("Listing date")]
        public DateTime AddedOn { get; set; }

        //decide how to add categories and connect with other classes
        */
    }
}
