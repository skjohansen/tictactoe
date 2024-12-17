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
            _console.WriteLine("Welcome to the tictactoe!");
        }
    }
}
