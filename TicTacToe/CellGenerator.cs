using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class CellGenerator
    {
        public Cell[] Cells { get; set; }
        public Cell[][] Rows { get; set; }
        public Cell[][] Columns { get; set; }

        public void CreateCells()
        {
            Cell cell0 = new("A1");
            Cell cell1 = new("A2");
            Cell cell2 = new("A3");
            Cell cell3 = new("B1");
            Cell cell4 = new("B2");
            Cell cell5 = new("B3");
            Cell cell6 = new("C1");
            Cell cell7 = new("C2");
            Cell cell8 = new("C3");
            Cells = new Cell[] {cell0, cell1, cell2, cell3, cell4,
            cell5, cell6, cell7, cell8};
        }

        public void CreateCellRows()
        {
            Cell[] row0 = new Cell[] { Cells[0], Cells[1], Cells[2] };
            Cell[] row1 = new Cell[] { Cells[3], Cells[4], Cells[5] };
            Cell[] row2 = new Cell[] { Cells[6], Cells[7], Cells[8] };
            Rows = new Cell[][] {row0, row1, row2};
        }

        public void CreateCellColumns()
        {
            Cell[] column1 = new Cell[] { Cells[0], Cells[3], Cells[6] };
            Cell[] column2 = new Cell[] { Cells[1], Cells[4], Cells[7] };
            Cell[] column3 = new Cell[] { Cells[2], Cells[5], Cells[8] };
            Columns = new Cell[][] {column1, column2, column3};
        }
    }
}
