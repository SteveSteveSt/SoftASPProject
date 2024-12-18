using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SoftUniGamesApp.Common.EntityValidationConstants.Game;
using static SoftUniGamesApp.Common.ApplicationConstants;

namespace SoftUniGamesApp.Web.ViewModels.Game
{
    public class AddGameInputModel
    {
        public AddGameInputModel()
        {
            this.ReleaseDate = DateTime.UtcNow.ToString(GamesAppDateFormat);
            this.LastUpdate = this.ReleaseDate;
        }

        [Required]
        [MinLength(TitleMinLength)]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MinLength(DescriptionMinLength)]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MinLength(GenreMinLength)]
        [MaxLength(GenreMaxLength)]
        public string Genre { get; set; } = null!;

        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string LastUpdate { get; set; }

        [Required]
        [MinLength(StudioMinLength)]
        [MaxLength(StudioMaxLength)]
        public string Studio { get; set; } = null!;
    }
}
