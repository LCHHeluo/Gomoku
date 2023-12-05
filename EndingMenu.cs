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
    public partial class EndingMenu : UserControl
    {
        private Form gameScene;
        private Form menuScene = Application.OpenForms["MenuScene"];//找尋該程式中已經開啟的Form
        private string lblWinnerText = "";
        public string LblWinnerText
        {
            get
            {
                return lblWinnerText;
            }
            set
            {
                lblWinnerText = value;
                LblWinner.Text = lblWinnerText + "勝利";
            }
        }
        public EndingMenu()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnGoToMenu_Click(object sender, EventArgs e)
        {
            gameScene = FindForm();//找這個物件所處的Form
            menuScene.Show();
            gameScene.Close();
            gameScene.Dispose();
        }

        private void BtnWatchBoard_Click(object sender, EventArgs e)
        {
            gameScene = FindForm();//找這個物件所處的Form
            //gameMode = gameScene.gm.GameMode.Watch;
            Hide();

        }
    }
}
