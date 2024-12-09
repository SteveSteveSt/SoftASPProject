using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SoftUniGamesApp.Data.Models
{
    public class Bundle
    {
        [Key]
        [Comment("Bundle Identifier")]
        public int Id { get; set; }
    }
}
