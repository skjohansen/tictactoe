using tictactoe.Application.Console;

namespace tictactoe.Application
{
    public class tictactoeRunner
    {
        IConsole _console;
        IPlayer _startPlayer;
        public tictactoeRunner(IConsole consoleDi, IPlayer randomPlayer)
        {
            _console = consoleDi;
            _startPlayer = randomPlayer;
        }

        public void Run()
        {
            var stringPlayer = _startPlayer.RandomPlayer();
            _console.WriteLine("Game Board Creation…");
            _console.WriteLine(" | |");
            _console.WriteLine("-+-+-");
            _console.WriteLine(" | |");
            _console.WriteLine("-+-+-");
            _console.WriteLine(" | |");
            _console.WriteLine("");
            _console.WriteLine("Board Created.");
            _console.WriteLine(PresentStarter(stringPlayer));
        }

        public string PresentStarter(string starter)
        {
            return $"The game will start with player {starter}";
        }
    }
}
