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
                lblWinner.Text = lblWinnerText + "勝利";
            }
        }
        public EndingMenu()
        {
            InitializeComponent();
        }
    }
}
