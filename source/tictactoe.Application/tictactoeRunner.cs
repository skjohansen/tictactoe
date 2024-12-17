using tictactoe.Application.Console;

namespace tictactoe.Application
{
    public class tictactoeRunner
    {
        IConsole _console;
        public tictactoeRunner(IConsole consoleDi)
        {
            _console = consoleDi;
        }

        public void Run()
        {
            _console.WriteLine("Game Board Creation…");
            _console.WriteLine(" | |");
            _console.WriteLine("-+-+-");
            _console.WriteLine(" | |");
            _console.WriteLine("-+-+-");
            _console.WriteLine(" | |");
            _console.WriteLine("");
            _console.WriteLine("Board Created.");
            _console.WriteLine(PresentStarter("X"));
        }

        public string PresentStarter(string starter)
        {
            return $"The game will start with player {starter}";
        }
    }
}
