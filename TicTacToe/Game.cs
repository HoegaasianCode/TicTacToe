using System;

namespace TicTacToe
{
    class Game
    {
        private readonly Cell[][] _rows;
        private readonly Cell[][] _columns;
        private readonly Player Player1;
        private readonly Player Player2;
        private Player winner;

        public Game(Cell[][] rows, Cell[][] columns,
            Player player1, Player player2)
        {
            _rows = rows;
            _columns = columns;
            Player1 = player1;
            Player2 = player2;
            RunGame();
        }

        private void RunGame()
        {
            string coordinate;
            while (true)
            {
                coordinate = _player1.GetCoordinate();
                _player1.Move(coordinate);
                IsWinCondition(_rows);
                IsWinCondition(_columns);
                if (winner != null) break;
                coordinate = _player2.GetCoordinate();
                _player2.Move(coordinate);
                IsWinCondition(_rows);
                IsWinCondition(_columns);
                if (winner != null) break;
            }
            PrintWinner();
        }

        private void IsWinCondition(Cell[][] cellStructures)
        {
            for (int i = 0; i < cellStructures.Length; i++)
            {
                Cell[] cells = cellStructures[i];
                int player1Count = 0;
                int player2Count = 0;
                for (int j = 0; j < cells.Length; j++)
                {
                    Cell cell = cells[j];
                    if (cell.IsMarkedByPlayer1) player1Count++;
                    if (cell.IsMarkedByPlayer2) player2Count++;
                }
                if (player1Count == 3) winner = Player1;
                if (player2Count == 3) winner = Player2;
            }
        }

        private void PrintWinner()
        {
            Console.WriteLine($"{winner.UserName} wins.");
        }
    }
}
