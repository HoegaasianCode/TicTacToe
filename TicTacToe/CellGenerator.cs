using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class CellGenerator
    {
        private Cell[] cells;
        private Cell[][] rows;
        private Cell[][] columns;

        public CellGenerator()
        {
            CreateCells();
            CreateRows();
            CreateColumns();
            CreatePlayers();
        }

        private void CreateCells()
        {
            Cell cell = new("A1");
            Cell cell1 = new("A2");
            Cell cell2 = new("A3");
            Cell cell3 = new("B1");
            Cell cell4 = new("B2");
            Cell cell5 = new("B3");
            Cell cell6 = new("C1");
            Cell cell7 = new("C2");
            Cell cell8 = new("C3");
            cells = new Cell[] {cell, cell1, cell2, cell3, cell4,
            cell5, cell6, cell7, cell8};
        }

        private void CreateRows()
        {
            Cell[] row = new Cell[] { cells[0], cells[1], cells[2] };
            Cell[] row1 = new Cell[] { cells[3], cells[4], cells[5] };
            Cell[] row2 = new Cell[] { cells[6], cells[7], cells[8] };
            rows = new Cell[][] {row, row1, row2};
        }

        private void CreateColumns()
        {
            Cell[] column = new Cell[] { cells[0], cells[3], cells[6] };
            Cell[] column1 = new Cell[] { cells[1], cells[4], cells[7] };
            Cell[] column2 = new Cell[] { cells[2], cells[5], cells[8] };
            columns = new Cell[][] {column, column1, column2};
        }

        private void CreatePlayers() => new PlayerGenerator(cells, rows, columns);
    }
}
