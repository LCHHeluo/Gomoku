using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gomoku
{
    abstract class Piece : PictureBox
    {
        private static readonly int IMAGE_WIDTH = Properties.Resources.black.Width;
        public Piece(int x, int y) 
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);
            this.Location = new Point(x - IMAGE_WIDTH / 2, y - IMAGE_WIDTH / 2);
        }
        public abstract PieceType GetPieceType();
    }
}
