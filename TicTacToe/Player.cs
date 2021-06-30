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
        public readonly string UserName;
        private readonly Cell[] _cells;

        public Player(int playerNo, string playerNumber, Cell[] cells)
        {
            PlayerNo = playerNo;
            UserName = playerNumber;
            _cells = cells;
        }

        public string GetCoordinate()
        {
            Console.WriteLine($"{UserName}: Enter a coordinate");
            string coordinate = Console.ReadLine();
            return coordinate;
        }

        private void Move(string coordinate)
        {
            for (int i = 0; i < _cells.Length; i++)
            {
                Cell cell = _cells[i];
                if (cell.Coordinate == coordinate) cell.SetPlayerMove(this);
            }
        }
    }
}
