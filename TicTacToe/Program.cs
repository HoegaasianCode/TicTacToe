using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            CellGenerator cellGenerator = new();
            cellGenerator.CreateCells();
            cellGenerator.CreateCellRows();
            cellGenerator.CreateCellColumns();
            Cell[] cells = cellGenerator.Cells;
            Cell[][] rows = cellGenerator.Rows;
            Cell[][] columns = cellGenerator.Columns;
            PlayerGenerator playerGenerator = new();
            playerGenerator.ReadPlayerNames();
            Player player1 = playerGenerator.Player1;
            Player player2 = playerGenerator.Player2;
            Game game = new(cells, rows, columns, player1, player2);
            game.Run();
        }
    }
}
