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
    public partial class MenuScene : Form
    {
        public Form gameScene;
        public MenuScene()
        {
            InitializeComponent();
        }

        private void BtnTwoPlayer_Click(object sender, EventArgs e)
        {
            Hide();
            gameScene = new GameScene();
            gameScene.ShowDialog();
            Close();
        }
    }
}
