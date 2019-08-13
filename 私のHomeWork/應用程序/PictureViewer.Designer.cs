namespace 私のHomeWork.應用程序
{
    partial class PictureViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟目錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.存我們ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.走你ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟目錄ToolStripMenuItem,
            this.存我們ToolStripMenuItem,
            this.走你ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 開啟目錄ToolStripMenuItem
            // 
            this.開啟目錄ToolStripMenuItem.Name = "開啟目錄ToolStripMenuItem";
            this.開啟目錄ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.開啟目錄ToolStripMenuItem.Text = "開啟目錄";
            this.開啟目錄ToolStripMenuItem.Click += new System.EventHandler(this.開啟目錄ToolStripMenuItem_Click);
            // 
            // 存我們ToolStripMenuItem
            // 
            this.存我們ToolStripMenuItem.Name = "存我們ToolStripMenuItem";
            this.存我們ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.存我們ToolStripMenuItem.Text = "存我們";
            this.存我們ToolStripMenuItem.Click += new System.EventHandler(this.存我們ToolStripMenuItem_Click);
            // 
            // 走你ToolStripMenuItem
            // 
            this.走你ToolStripMenuItem.Name = "走你ToolStripMenuItem";
            this.走你ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.走你ToolStripMenuItem.Text = "走你";
            this.走你ToolStripMenuItem.Click += new System.EventHandler(this.走你ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 419);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureViewer";
            this.Text = "PictureViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟目錄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 存我們ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 走你ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}