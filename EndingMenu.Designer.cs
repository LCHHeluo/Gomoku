namespace Gomoku
{
    partial class EndingMenu
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbEndingbg = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.btnWatchBoard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndingbg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEndingbg
            // 
            this.pbEndingbg.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.pbEndingbg.Location = new System.Drawing.Point(0, 0);
            this.pbEndingbg.Name = "pbEndingbg";
            this.pbEndingbg.Size = new System.Drawing.Size(400, 200);
            this.pbEndingbg.TabIndex = 0;
            this.pbEndingbg.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.btnRestart.Location = new System.Drawing.Point(40, 70);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "重新開始";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnGoToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToMenu.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGoToMenu.ForeColor = System.Drawing.Color.White;
            this.btnGoToMenu.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.btnGoToMenu.Location = new System.Drawing.Point(216, 69);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(150, 50);
            this.btnGoToMenu.TabIndex = 2;
            this.btnGoToMenu.Text = "回到選單";
            this.btnGoToMenu.UseVisualStyleBackColor = true;
            // 
            // btnWatchBoard
            // 
            this.btnWatchBoard.FlatAppearance.BorderSize = 0;
            this.btnWatchBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnWatchBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchBoard.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWatchBoard.ForeColor = System.Drawing.Color.White;
            this.btnWatchBoard.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.btnWatchBoard.Location = new System.Drawing.Point(40, 125);
            this.btnWatchBoard.Name = "btnWatchBoard";
            this.btnWatchBoard.Size = new System.Drawing.Size(150, 50);
            this.btnWatchBoard.TabIndex = 3;
            this.btnWatchBoard.Text = "觀看棋盤";
            this.btnWatchBoard.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.btnExit.Location = new System.Drawing.Point(216, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "關閉遊戲";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.lblWinner.Location = new System.Drawing.Point(140, 25);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(119, 34);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "黑旗勝利";
            // 
            // EndingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWatchBoard);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pbEndingbg);
            this.Name = "EndingMenu";
            this.Size = new System.Drawing.Size(400, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbEndingbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEndingbg;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnGoToMenu;
        private System.Windows.Forms.Button btnWatchBoard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWinner;
    }
}
