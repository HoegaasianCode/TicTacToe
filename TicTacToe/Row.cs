using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    struct Row
    {
        public readonly Cell[] Cells;

        public Row(params Cell[] cells)
        {
            Cells = cells;
        }
    }
}
