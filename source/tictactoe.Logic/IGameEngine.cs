using System;

namespace tictactoe.Logic;

public interface IGameEngine
{
    string[,] GameBoard();
    void NextPlayer();
    bool SetPeice(uint x, uint y);
    string HasWinner();
    string CurrentPlayer { get; set; }

    string GameState { get; set; }
}
