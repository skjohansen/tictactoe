using tictactoe.Application.Console;

namespace tictactoe.Application;

class Program
{
    static void Main(string[] args)
    {
        tictactoeRunner tictactoeRunner = new tictactoeRunner(new ConsoleWrapper(), new Player());
        tictactoeRunner.Run();
    }
}
