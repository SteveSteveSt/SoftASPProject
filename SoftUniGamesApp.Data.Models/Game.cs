namespace SoftUniGamesApp.Data.Models
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string Genre { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

        public DateTime LastUpdate { get; set; }

        public string Studio { get; set; } = null!;

        public virtual ICollection<BundleGame> BundlesGames { get; set; } = new HashSet<BundleGame>();
    }
}
