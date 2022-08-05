using MinimalProblem.Models;

namespace MinimalProblem.Data
{
    public class GameService
    {
        public static Game game = new Game();

        public static Task<Game> GetGameAsync()
        {
            return Task.FromResult(game);
        }
    }
}