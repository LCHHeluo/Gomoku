namespace Gomoku
{
    partial class MenuScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnEndingTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等距更紗黑體 TC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(243, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "自製五子棋";
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Font = new System.Drawing.Font("等距更紗黑體 TC Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTwoPlayer.Location = new System.Drawing.Point(300, 350);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnTwoPlayer.TabIndex = 1;
            this.btnTwoPlayer.Text = "雙人模式";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.BtnTwoPlayer_Click);
            // 
            // btnEndingTest
            // 
            this.btnEndingTest.Font = new System.Drawing.Font("等距更紗黑體 TC Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEndingTest.Location = new System.Drawing.Point(300, 418);
            this.btnEndingTest.Name = "btnEndingTest";
            this.btnEndingTest.Size = new System.Drawing.Size(150, 50);
            this.btnEndingTest.TabIndex = 2;
            this.btnEndingTest.Text = "選單測試";
            this.btnEndingTest.UseVisualStyleBackColor = true;
            this.btnEndingTest.Click += new System.EventHandler(this.btnEndingTest_Click);
            // 
            // MenuScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.btnEndingTest);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.label1);
            this.Name = "MenuScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button btnEndingTest;
    }
}