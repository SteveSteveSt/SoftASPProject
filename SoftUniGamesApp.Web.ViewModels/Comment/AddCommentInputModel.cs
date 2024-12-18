using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SoftUniGamesApp.Common.ApplicationConstants;
using static SoftUniGamesApp.Common.EntityValidationConstants.Comment;

namespace SoftUniGamesApp.Web.ViewModels.Comment
{
    public class AddCommentInputModel
    {
        public AddCommentInputModel()
        {
            this.CommentDate = DateTime.UtcNow.ToString(GamesAppDateFormat);
        }

        [Required]
        [MinLength(MessageMinLength)]
        [MaxLength(MessageMaxLength)]
        public string Message { get; set; } = null!;

        [Required]
        public string CommentDate { get; set; }
    }
}
