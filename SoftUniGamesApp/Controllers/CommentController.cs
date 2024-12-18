using System.Globalization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using SoftUniGamesApp.Data;
using SoftUniGamesApp.Data.Models;
using SoftUniGamesApp.Web.ViewModels.Comment;
using static SoftUniGamesApp.Common.ApplicationConstants;

namespace SoftUniGamesApp.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly GamesDbContext dbContext;

        public CommentController(GamesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index(string id)
        {
            bool isIdValid = Guid.TryParse(id, out Guid guidId);
            if (!isIdValid)
            {
                return this.RedirectToAction(Url.Content("~/"));
            }

            IEnumerable<Comment> GameComments = this.dbContext.Comments.Where(c =>  c.GameId == guidId).ToList();

            return View(GameComments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(AddCommentInputModel inputModel)
        {
            bool isCommentDateValid = DateTime.TryParseExact(inputModel.CommentDate, GamesAppDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime commentDate);
            if (!isCommentDateValid)
            {
                this.ModelState.AddModelError(nameof(inputModel.CommentDate), String.Format("The comment date must be in the {0} format", GamesAppDateFormat));
            }
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            Comment comment = new Comment()
            {
                Message = inputModel.Message
            };

            this.dbContext.Comments.Add(comment);
            this.dbContext.SaveChanges();

            return this.RedirectToAction(nameof(Index));
        }
    }
}
