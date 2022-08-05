namespace MinimalProblem.Models
{
    public class Game
    {
        public List<PlayerState> Players { get; set; } = new List<PlayerState>();

        public Game()
        {

        }

        public void AddPlayer(PlayerState player)
        {
            Players.Add(player);
        }
    }
}
