using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class Black_Piece : Piece
    {
        public Black_Piece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.black;
        }
    }
}
