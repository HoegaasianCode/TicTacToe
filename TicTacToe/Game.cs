using System;

namespace TicTacToe
{
    class Game
    {
        private readonly Cell[] _cells;
        private readonly Cell[][] _rows;
        private readonly Cell[][] _columns;
        private readonly Player Player1;
        private readonly Player Player2;
        public Player Winner;

        public Game(Cell[] cells, Cell[][] rows, Cell[][] columns,
            Player player1, Player player2)
        {
            _cells = cells;
            _columns = columns;
            _rows = rows;
            Player1 = player1;
            Player2 = player2;
        }

        public void Run()
        {
            while (true)
            {
                TakeCoordinate(Player1);
                IsWinCondition(_rows);
                IsWinCondition(_columns);
                if (Winner != null) break;
                TakeCoordinate(Player2);
                IsWinCondition(_rows);
                IsWinCondition(_columns);
                if (Winner != null) break;
            }
            PrintWinner();
        }

        public void TakeCoordinate(Player player)
        {
            Console.WriteLine($"{player.PlayerUserName}: Enter a coordinate");
            string coordinate = Console.ReadLine();
            SetCellState(coordinate, player);
        }

        private void SetCellState(string coordinate, Player player)
        {
            for(int i = 0; i < _cells.Length; i++)
            {
                Cell cell = _cells[i];
                if (cell.Coordinate == coordinate)
                {
                    cell.SetPlayer(player);
                    break;
                }
            }
        }

        public void IsWinCondition(Cell[][] cellStructure)
        {
            for (int i = 0; i < cellStructure.Length; i++)
            {
                Cell[] cells = cellStructure[i];
                int player1Count = 0;
                int player2Count = 0;
                for (int j = 0; j < cells.Length; j++)
                {
                    Cell cell = cells[j];
                    if (cell.IsMarkedByPlayer1) player1Count++;
                    if (cell.IsMarkedByPlayer2) player2Count++;
                }
                if (player1Count == 3) Winner = Player1;
                if (player2Count == 3) Winner = Player2;
            }
        }

        private void PrintWinner()
        {
            Console.WriteLine($"{Winner.PlayerUserName} wins.");
        }
    }
}
