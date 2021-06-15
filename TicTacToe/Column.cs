using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    struct Column
    {
        public Cell[] Cells;

        public Column(params Cell[] cells)
        {
            Cells = cells;
        }
    }
}
