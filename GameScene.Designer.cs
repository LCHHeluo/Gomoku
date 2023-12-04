namespace Gomoku
{
    partial class GameScene
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("等距更紗黑體 TC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(295, 30);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(152, 26);
            this.CurrentPlayerLabel.TabIndex = 0;
            this.CurrentPlayerLabel.Text = "當前玩家：黑棋";
            this.CurrentPlayerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gomoku.Properties.Resources.board;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.CurrentPlayerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五子棋";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameScene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameScene_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentPlayerLabel;
    }
}

