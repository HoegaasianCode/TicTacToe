using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Cell
    {
        public readonly string Coordinate;
        public bool IsMarkedByPlayer1;
        public bool IsMarkedByPlayer2;

        public Cell(string coordinate)
        {
            Coordinate = coordinate;
            IsMarkedByPlayer1 = false;
            IsMarkedByPlayer2 = false;
        }

        public void SetPlayerMove(Player player)
        {
            if (player.PlayerNo == 1) IsMarkedByPlayer1 = true;
            if (player.PlayerNo == 2) IsMarkedByPlayer2 = true;
        }
    }
}
