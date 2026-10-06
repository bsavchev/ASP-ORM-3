namespace GameStoreApp.Data.Domain
{
    public class Purchase
    {
        public int Id { get; set; }

        public string? Type { get; set; }

        public string? ProductKey { get; set; }

        public DateTime Date { get; set; }

        public int CardId { get; set; }

        public Card Card { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
