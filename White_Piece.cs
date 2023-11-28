using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class White_Piece: Piece
    {
        public White_Piece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.white;
        }
        public override PieceType GetPieceType()
        {
            return PieceType.WHITE;
        }
    }
}
