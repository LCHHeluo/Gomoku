using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1 : Form
    {
        private GameManager gm = new GameManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("" + e.X + "," + e.Y); //測試用
            Piece piece = gm.PlaceAPiece(e.X, e.Y);
            if (piece != null)
                this.Controls.Add(piece);
            gm.CheckWinner(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (gm.CanBePlace(e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor= Cursors.Default;
        }
    }
}
