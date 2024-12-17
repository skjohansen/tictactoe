using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe.Logic
{
    public class GameEngine
    {
        public string[,] GameBoard()
        {
            return new string[,] 
                    {
                        { " ", " ", " " },
                        { " ", " ", " " },
                        { " ", " ", " " }
                    };
        }
    }
}
