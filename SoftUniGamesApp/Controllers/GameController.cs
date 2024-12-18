using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using SoftUniGamesApp.Data;
using SoftUniGamesApp.Data.Models;
using SoftUniGamesApp.Web.ViewModels.Game;

namespace SoftUniGamesApp.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly GamesDbContext dbContext;

        public GameController(GamesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Game> allGames = this.dbContext.Games.ToList();

            return this.View(allGames);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(AddGameInputModel inputModel)
        {
            bool isReleaseDateValid = DateTime.TryParseExact(inputModel.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate);
            if (!isReleaseDateValid)
            {
                this.ModelState.AddModelError(nameof(inputModel.ReleaseDate), "The release date must be in the dd/MM/yyy format");
            }
            bool isLastUpdateValid = DateTime.TryParseExact(inputModel.LastUpdate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime lastUpdate);
            if (!isLastUpdateValid)
            {
                this.ModelState.AddModelError(nameof(inputModel.LastUpdate), "The last update date must be in the dd/MM/yyy format");
            }
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            Game game = new Game()
            {
                Title = inputModel.Title,
                Genre = inputModel.Genre,
                ReleaseDate = releaseDate,
                LastUpdate = lastUpdate,
                Studio = inputModel.Studio,
                Description = inputModel.Description
            };

            this.dbContext.Games.Add(game);
            this.dbContext.SaveChanges();

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            bool isIdValid = Guid.TryParse(id, out Guid guidId);
            if (!isIdValid)
            {
                return this.RedirectToAction(nameof(Index));
            }

            Game? game = this.dbContext.Games.FirstOrDefault(g => g.Id == guidId);
            if (game == null)
            {
                return this.RedirectToAction(nameof(Index));
            }

            return this.View(game);
        }
    }
}
