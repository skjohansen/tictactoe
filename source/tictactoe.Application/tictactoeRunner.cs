using tictactoe.Application.Console;
using tictactoe.Logic;

namespace tictactoe.Application
{
    public class tictactoeRunner
    {
        readonly IConsole _console;
        readonly IPlayer _startPlayer;
        readonly IGameEngine _gameEngine;
        public tictactoeRunner(IConsole consoleDi, IPlayer randomPlayer, IGameEngine gameEngine)
        {
            _console = consoleDi;
            _startPlayer = randomPlayer;
            _gameEngine = gameEngine;
        }

        public void Run()
        {
            var player = _startPlayer.RandomPlayer();
            _gameEngine.CurrentPlayer = player;


            if(_gameEngine.GameState == "started") ShowInitGame();
            else if(_gameEngine.GameState == "won") ShowWinner();
            else ShowMidgame();

        }

        public void ShowInitGame(){
            _console.WriteLine("Game Board Creation…");
            ShowBoard(_gameEngine.GameBoard());
            _console.WriteLine("");
            _console.WriteLine("Board Created.");
            _console.WriteLine(PresentStarter(_gameEngine.CurrentPlayer));
        }

        public void ShowWinner(){
            _console.WriteLine($"Player {_gameEngine.CurrentPlayer}:");
            ShowBoard(_gameEngine.GameBoard());
            _console.WriteLine($"PLAYER {_gameEngine.CurrentPlayer} WON!");
        }

        public void ShowMidgame(){
            _console.WriteLine($"Player {_gameEngine.CurrentPlayer}:");
            ShowBoard(_gameEngine.GameBoard());
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
