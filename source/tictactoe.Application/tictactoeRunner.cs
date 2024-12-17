using tictactoe.Application.Console;
using tictactoe.Logic;

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
            var gameEngine = new GameEngine();
            var gameBoard = gameEngine.GameBoard();
            _console.WriteLine("Game Board Creation…");
            ShowBoard(gameBoard);
            _console.WriteLine("");
            _console.WriteLine("Board Created.");
            _console.WriteLine(PresentStarter(stringPlayer));
        }

        public void ShowBoard(string[,] board){
            _console.WriteLine($"{board[0,0]}|{board[0,1]}|{board[0,2]}");
            _console.WriteLine($"-+-+-");
            _console.WriteLine($"{board[1,0]}|{board[1,1]}|{board[1,2]}");
            _console.WriteLine($"-+-+-");
            _console.WriteLine($"{board[2,0]}|{board[2,1]}|{board[2,2]}");
        }

        public string PresentStarter(string starter)
        {
            return $"The game will start with player {starter}";
        }
    }
}
