using tictactoe.Application.Console;

namespace tictactoe.Application
{
    public class Player : IPlayer
    {
        private static readonly Random random = new Random();
        public string RandomPlayer()
        {
            return random.Next(0, 2) == 0 ? "X" : "O";
        }
    }
}
