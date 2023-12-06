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
        private Form gameScene;
        public MenuScene()
        {
            InitializeComponent();
        }

        private void BtnTwoPlayer_Click(object sender, EventArgs e)
        {
            //初始化回傳值讓回傳值是執行開始新遊戲的DialogResult.Yes
            DialogResult gameSceneDR = DialogResult.Yes;
            /*
            至少做一次的開始新遊戲，等遊戲關閉後再根據回傳值決定是否開啟新遊戲
            或是關閉遊戲
            */
            do
            {
                Hide();
                gameScene = new GameScene();
                gameSceneDR = gameScene.ShowDialog();
            } while (gameSceneDR == DialogResult.Yes);//收到開始新遊戲的回傳值
            if (gameSceneDR == DialogResult.Cancel)//收到關閉視窗的回傳值
            {
                //關閉整個程式
                System.Environment.Exit(0);
            }
            else//收到其他回傳值
                //顯示主選單
                Show();
        }
    }
}
