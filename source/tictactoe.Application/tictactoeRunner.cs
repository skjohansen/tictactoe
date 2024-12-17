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
            _console.WriteLine("The game will start with player X");
        }
    }
}
