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
    public partial class GameScene : Form
    {
        private GameManager gm = new GameManager();
        public GameScene()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("" + e.X + "," + e.Y); //測試用
            Piece piece = gm.PlaceAPiece(e.X, e.Y);
            if (piece != null)
                this.Controls.Add(piece);

            switch (gm.CheckWinner(e.X, e.Y))
            {
                case PieceType.BLACK:
                    MessageBox.Show("黑棋玩家贏了");
                    break;

                case PieceType.WHITE:
                    MessageBox.Show("白棋玩家贏了");
                    break;
                default:
                    break;
            }
            switch (gm.currentPlayer)
            {
                case PieceType.BLACK:
                    CurrentPlayerLabel.Text = "當前玩家：黑棋";
                    break;

                case PieceType.WHITE:
                    CurrentPlayerLabel.Text = "當前玩家：白棋";
                    break;
            }
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
