using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class PlayerGenerator
    {
        private readonly Cell[] _cells;
        private readonly Cell[][] _rows;
        private readonly Cell[][] _columns;
        private Player player1;
        private Player player2;

        public PlayerGenerator(Cell[] cells, Cell[][] rows, Cell[][] columns)
        {
            _cells = cells;
            _rows = rows;
            _columns = columns;
            GetPlayerNames();
            NewGame();
        }

        private void GetPlayerNames()
        {
            Console.WriteLine("Enter 1st player's name: ");
            string userName1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd player's name: ");
            string userName2 = Console.ReadLine();
            CreatePlayers(userName1, userName2);
        }

        private void CreatePlayers(string userName1, string userName2)
        {
            player1 = new(1, userName1, _cells);
            player2 = new(2, userName2, _cells);
        }

        private void NewGame() => new Game(_rows, _columns, player1, player2);
    }
}
