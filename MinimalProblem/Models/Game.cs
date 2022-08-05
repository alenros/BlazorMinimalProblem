namespace MinimalProblem.Models
{
    public class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public Game()
        {

        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
