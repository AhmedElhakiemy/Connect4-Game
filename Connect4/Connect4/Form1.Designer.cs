namespace Connect4
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer_1_score = new System.Windows.Forms.Label();
            this.lblPlayer_2_score = new System.Windows.Forms.Label();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.lbl_Vs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Location = new System.Drawing.Point(42, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 740);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Thistle;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(1086, 92);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReset_MouseClick);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayer1.Location = new System.Drawing.Point(134, 2);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(215, 65);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1 :";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2.Location = new System.Drawing.Point(596, 2);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(215, 65);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2 :";
            // 
            // lblPlayer_1_score
            // 
            this.lblPlayer_1_score.AutoSize = true;
            this.lblPlayer_1_score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer_1_score.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_1_score.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayer_1_score.Location = new System.Drawing.Point(355, 3);
            this.lblPlayer_1_score.Name = "lblPlayer_1_score";
            this.lblPlayer_1_score.Size = new System.Drawing.Size(55, 65);
            this.lblPlayer_1_score.TabIndex = 6;
            this.lblPlayer_1_score.Text = "0";
            // 
            // lblPlayer_2_score
            // 
            this.lblPlayer_2_score.AutoSize = true;
            this.lblPlayer_2_score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer_2_score.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer_2_score.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer_2_score.Location = new System.Drawing.Point(817, 3);
            this.lblPlayer_2_score.Name = "lblPlayer_2_score";
            this.lblPlayer_2_score.Size = new System.Drawing.Size(55, 65);
            this.lblPlayer_2_score.TabIndex = 7;
            this.lblPlayer_2_score.Text = "0";
            // 
            // btnResetScore
            // 
            this.btnResetScore.BackColor = System.Drawing.Color.Thistle;
            this.btnResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetScore.Location = new System.Drawing.Point(1069, 192);
            this.btnResetScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(135, 38);
            this.btnResetScore.TabIndex = 8;
            this.btnResetScore.Text = "Reset Score";
            this.btnResetScore.UseVisualStyleBackColor = false;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // lbl_Vs
            // 
            this.lbl_Vs.AutoSize = true;
            this.lbl_Vs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vs.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vs.Location = new System.Drawing.Point(475, 21);
            this.lbl_Vs.Name = "lbl_Vs";
            this.lbl_Vs.Size = new System.Drawing.Size(46, 37);
            this.lbl_Vs.TabIndex = 9;
            this.lbl_Vs.Text = "Vs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 803);
            this.Controls.Add(this.lbl_Vs);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.lblPlayer_2_score);
            this.Controls.Add(this.lblPlayer_1_score);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer_1_score;
        private System.Windows.Forms.Label lblPlayer_2_score;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.Label lbl_Vs;
    }
}

