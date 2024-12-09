using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SoftUniGamesApp.Data.Models
{
    public class Collection
    {
        [Key]
        [Comment("Collection Identifier")]
        public int Id { get; set; }
    }
}
