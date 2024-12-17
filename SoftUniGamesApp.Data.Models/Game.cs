namespace SoftUniGamesApp.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public string Studio { get; set; } = null!;


    }
}
