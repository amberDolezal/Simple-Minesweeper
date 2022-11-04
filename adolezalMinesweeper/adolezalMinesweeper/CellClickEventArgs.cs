using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adolezalMinesweeper
{
    public class CellClickEventArgs : EventArgs
    {
        int x;
        int y;

        public CellClickEventArgs(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; }
        public int Y { get => y; }
    }
}
