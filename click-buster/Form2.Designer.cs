namespace click_buster
{
    partial class F_Main
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
            this.B_Start = new System.Windows.Forms.Button();
            this.L_Time = new System.Windows.Forms.Label();
            this.L_Score = new System.Windows.Forms.Label();
            this.L_Score_Sum = new System.Windows.Forms.Label();
            this.PG_Time = new System.Windows.Forms.ProgressBar();
            this.P_Enemy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(12, 12);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(80, 49);
            this.B_Start.TabIndex = 0;
            this.B_Start.Text = "スタート";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.L_Time.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Time.Location = new System.Drawing.Point(98, 12);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(97, 24);
            this.L_Time.TabIndex = 1;
            this.L_Time.Text = "残り時間";
            // 
            // L_Score
            // 
            this.L_Score.AutoSize = true;
            this.L_Score.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Score.Location = new System.Drawing.Point(249, 12);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(58, 24);
            this.L_Score.TabIndex = 2;
            this.L_Score.Text = "得点";
            // 
            // L_Score_Sum
            // 
            this.L_Score_Sum.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.L_Score_Sum.Location = new System.Drawing.Point(249, 45);
            this.L_Score_Sum.Name = "L_Score_Sum";
            this.L_Score_Sum.Size = new System.Drawing.Size(123, 26);
            this.L_Score_Sum.TabIndex = 3;
            this.L_Score_Sum.Text = "0";
            this.L_Score_Sum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PG_Time
            // 
            this.PG_Time.Location = new System.Drawing.Point(102, 45);
            this.PG_Time.Maximum = 10;
            this.PG_Time.Name = "PG_Time";
            this.PG_Time.Size = new System.Drawing.Size(141, 23);
            this.PG_Time.TabIndex = 4;
            this.PG_Time.Value = 10;
            // 
            // P_Enemy
            // 
            this.P_Enemy.BackColor = System.Drawing.Color.White;
            this.P_Enemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Enemy.Location = new System.Drawing.Point(12, 74);
            this.P_Enemy.Name = "P_Enemy";
            this.P_Enemy.Size = new System.Drawing.Size(354, 378);
            this.P_Enemy.TabIndex = 5;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 464);
            this.Controls.Add(this.P_Enemy);
            this.Controls.Add(this.PG_Time);
            this.Controls.Add(this.L_Score_Sum);
            this.Controls.Add(this.L_Score);
            this.Controls.Add(this.L_Time);
            this.Controls.Add(this.B_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Main_FormClosed_1);
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label L_Score_Sum;
        private System.Windows.Forms.ProgressBar PG_Time;
        private System.Windows.Forms.Panel P_Enemy;
    }
}