using tictactoe.Application.Console;
using tictactoe.Logic;

namespace tictactoe.Application;

class Program
{
    static void Main(string[] args)
    {
        tictactoeRunner tictactoeRunner = new tictactoeRunner(new ConsoleWrapper(), new Player(), new GameEngine());
        tictactoeRunner.Run();
    }
}
