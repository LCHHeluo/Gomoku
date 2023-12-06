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
            this.PbEndingbg = new System.Windows.Forms.PictureBox();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.BtnGoToMenu = new System.Windows.Forms.Button();
            this.BtnWatchBoard = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbEndingbg)).BeginInit();
            this.SuspendLayout();
            // 
            // PbEndingbg
            // 
            this.PbEndingbg.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.PbEndingbg.Location = new System.Drawing.Point(0, 0);
            this.PbEndingbg.Name = "PbEndingbg";
            this.PbEndingbg.Size = new System.Drawing.Size(400, 200);
            this.PbEndingbg.TabIndex = 0;
            this.PbEndingbg.TabStop = false;
            // 
            // BtnRestart
            // 
            this.BtnRestart.FlatAppearance.BorderSize = 0;
            this.BtnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestart.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRestart.ForeColor = System.Drawing.Color.White;
            this.BtnRestart.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.BtnRestart.Location = new System.Drawing.Point(40, 70);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(150, 50);
            this.BtnRestart.TabIndex = 1;
            this.BtnRestart.Text = "重新開始";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnGoToMenu
            // 
            this.BtnGoToMenu.FlatAppearance.BorderSize = 0;
            this.BtnGoToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.BtnGoToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoToMenu.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnGoToMenu.ForeColor = System.Drawing.Color.White;
            this.BtnGoToMenu.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.BtnGoToMenu.Location = new System.Drawing.Point(216, 69);
            this.BtnGoToMenu.Name = "BtnGoToMenu";
            this.BtnGoToMenu.Size = new System.Drawing.Size(150, 50);
            this.BtnGoToMenu.TabIndex = 2;
            this.BtnGoToMenu.Text = "回到選單";
            this.BtnGoToMenu.UseVisualStyleBackColor = true;
            this.BtnGoToMenu.Click += new System.EventHandler(this.BtnGoToMenu_Click);
            // 
            // BtnWatchBoard
            // 
            this.BtnWatchBoard.FlatAppearance.BorderSize = 0;
            this.BtnWatchBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.BtnWatchBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnWatchBoard.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnWatchBoard.ForeColor = System.Drawing.Color.White;
            this.BtnWatchBoard.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.BtnWatchBoard.Location = new System.Drawing.Point(40, 125);
            this.BtnWatchBoard.Name = "BtnWatchBoard";
            this.BtnWatchBoard.Size = new System.Drawing.Size(150, 50);
            this.BtnWatchBoard.TabIndex = 3;
            this.BtnWatchBoard.Text = "觀看棋盤";
            this.BtnWatchBoard.UseVisualStyleBackColor = true;
            this.BtnWatchBoard.Click += new System.EventHandler(this.BtnWatchBoard_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.BtnExit.Location = new System.Drawing.Point(216, 125);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "關閉遊戲";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblWinner
            // 
            this.LblWinner.AutoSize = true;
            this.LblWinner.BackColor = System.Drawing.Color.Transparent;
            this.LblWinner.Font = new System.Drawing.Font("等距更紗黑體 TC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblWinner.ForeColor = System.Drawing.Color.White;
            this.LblWinner.Image = global::Gomoku.Properties.Resources.Ending_Menu;
            this.LblWinner.Location = new System.Drawing.Point(140, 25);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(119, 34);
            this.LblWinner.TabIndex = 5;
            this.LblWinner.Text = "黑旗勝利";
            // 
            // EndingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LblWinner);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnWatchBoard);
            this.Controls.Add(this.BtnGoToMenu);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.PbEndingbg);
            this.Name = "EndingMenu";
            this.Size = new System.Drawing.Size(400, 200);
            ((System.ComponentModel.ISupportInitialize)(this.PbEndingbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbEndingbg;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnGoToMenu;
        private System.Windows.Forms.Button BtnWatchBoard;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblWinner;
    }
}
