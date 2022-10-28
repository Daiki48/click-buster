namespace click_buster
{
    partial class F_Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.B_level1 = new System.Windows.Forms.Button();
            this.B_level2 = new System.Windows.Forms.Button();
            this.B_level3 = new System.Windows.Forms.Button();
            this.B_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_level1
            // 
            this.B_level1.Location = new System.Drawing.Point(12, 12);
            this.B_level1.Name = "B_level1";
            this.B_level1.Size = new System.Drawing.Size(260, 74);
            this.B_level1.TabIndex = 0;
            this.B_level1.Text = "初級";
            this.B_level1.UseVisualStyleBackColor = true;
            this.B_level1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_level2
            // 
            this.B_level2.Location = new System.Drawing.Point(12, 92);
            this.B_level2.Name = "B_level2";
            this.B_level2.Size = new System.Drawing.Size(260, 74);
            this.B_level2.TabIndex = 1;
            this.B_level2.Text = "中級";
            this.B_level2.UseVisualStyleBackColor = true;
            // 
            // B_level3
            // 
            this.B_level3.Location = new System.Drawing.Point(12, 172);
            this.B_level3.Name = "B_level3";
            this.B_level3.Size = new System.Drawing.Size(260, 74);
            this.B_level3.TabIndex = 2;
            this.B_level3.Text = "上級";
            this.B_level3.UseVisualStyleBackColor = true;
            // 
            // B_close
            // 
            this.B_close.Location = new System.Drawing.Point(12, 275);
            this.B_close.Name = "B_close";
            this.B_close.Size = new System.Drawing.Size(260, 74);
            this.B_close.TabIndex = 3;
            this.B_close.Text = "終了";
            this.B_close.UseVisualStyleBackColor = true;
            this.B_close.Click += new System.EventHandler(this.B_close_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 434);
            this.Controls.Add(this.B_close);
            this.Controls.Add(this.B_level3);
            this.Controls.Add(this.B_level2);
            this.Controls.Add(this.B_level1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickBuster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_level1;
        private System.Windows.Forms.Button B_level2;
        private System.Windows.Forms.Button B_level3;
        private System.Windows.Forms.Button B_close;
    }
}

