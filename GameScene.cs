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
        private EndingMenu usEndingMenu = new EndingMenu();
        public GameMode gameMode = GameMode.Game;
        
        //private bool endFlag = false;
        public GameScene()
        {
            InitializeComponent();
        }

        private void GameScene_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameMode == GameMode.Game)
            {
                Piece piece = gm.PlaceAPiece(e.X, e.Y);
                if (piece != null)
                    this.Controls.Add(piece);

                switch (gm.CheckWinner(e.X, e.Y))
                {
                    case PieceType.BLACK:
                        usEndingMenu.LblWinnerText = "黑棋";
                        usEndingMenu.Location = new Point(175, 275);
                        Controls.Add(usEndingMenu);
                        usEndingMenu.BringToFront();//將物件層級放到最前面
                        gameMode = GameMode.Pause;
                        break;

                    case PieceType.WHITE:
                        usEndingMenu.LblWinnerText = "白棋";
                        usEndingMenu.Location = new Point(175, 275);
                        Controls.Add(usEndingMenu);
                        usEndingMenu.BringToFront();//將物件層級放到最前面
                        gameMode = GameMode.Pause;
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
            else if (gameMode == GameMode.Watch)
            {
                usEndingMenu.Show();
            }
            
        }

        private void GameScene_MouseMove(object sender, MouseEventArgs e)
        {
            LblTestGameMode.Text = gameMode + "Mode";//測試用
            if (gameMode == GameMode.Game)
            {
                if (gm.CanBePlace(e.X, e.Y))
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void GameScene_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (gameMode != GameMode.Pause)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
        /*
public void CleanBoard()
{
   gm.CleanBoard();
}
*/
    }
}
