using Microsoft.AspNetCore.Mvc;
using SoftUniGamesApp.Data;
using SoftUniGamesApp.Data.Models;

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
    }
}
