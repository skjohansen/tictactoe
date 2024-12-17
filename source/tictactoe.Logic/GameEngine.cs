using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace tictactoe.Logic
{
    public class GameEngine : IGameEngine
    {
        private string[,] _board;

        public string CurrentPlayer { get; set; }

        public string GameState { get; set; }

        public GameEngine(){
            _board = new string[,] 
                    {
                        { " ", " ", " " },
                        { " ", " ", " " },
                        { " ", " ", " " }
                    };
            GameState = "started";
        }

        public string[,] GameBoard()
        {
            return _board;
        }
        
        public void NextPlayer(){
            GameState = "midgame";
            if(CurrentPlayer == "X"){
                CurrentPlayer = "O";
                return;
            }
            CurrentPlayer = "X";
        }
    
        public bool SetPeice(uint x, uint y){
            if(!(_board[x,y] == " ")) return false;
            _board[x,y] = CurrentPlayer;
            return true;
        }

        public string HasWinner(){
            GameState = "midgame";
            if(_board[0,0] != "X") return string.Empty;
            if(_board[1,0] != "X") return string.Empty;
            if(_board[2,0] != "X") return string.Empty;
            GameState = "won";
            return "X"; // X is winner

        }
    }
}
