using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public int PlayerNo;
        public readonly string PlayerUserName;
        public int MatchesWon;

        public Player(int playerNo, string playerNumber)
        {
            PlayerNo = playerNo;
            PlayerUserName = playerNumber;
            MatchesWon = 0;
        }
    }
}
