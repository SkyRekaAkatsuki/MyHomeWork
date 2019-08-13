namespace 私のHomeWork
{
    partial class StudentScoreStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentScoreStatistics));
            this.label1 = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Data_Display_button = new System.Windows.Forms.Button();
            this.Add_Random_Data_button = new System.Windows.Forms.Button();
            this.Statistics_Data_button = new System.Windows.Forms.Button();
            this.Clear_Data_button = new System.Windows.Forms.Button();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Chineses_textBox = new System.Windows.Forms.TextBox();
            this.English_textBox = new System.Windows.Forms.TextBox();
            this.Japanese_textBox = new System.Windows.Forms.TextBox();
            this.Add_Random20_button = new System.Windows.Forms.Button();
            this.Display_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "暱稱:";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.Titlelabel.Font = new System.Drawing.Font("華康少女文字W5(P)", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Titlelabel.ForeColor = System.Drawing.Color.Red;
            this.Titlelabel.Location = new System.Drawing.Point(372, 9);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(314, 48);
            this.Titlelabel.TabIndex = 1;
            this.Titlelabel.Text = "學生成績統計";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(15, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "中文:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(15, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(15, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "日文:";
            // 
            // Add_Data_Display_button
            // 
            this.Add_Data_Display_button.Location = new System.Drawing.Point(19, 281);
            this.Add_Data_Display_button.Name = "Add_Data_Display_button";
            this.Add_Data_Display_button.Size = new System.Drawing.Size(186, 59);
            this.Add_Data_Display_button.TabIndex = 5;
            this.Add_Data_Display_button.Text = "加入上方資料並顯示";
            this.Add_Data_Display_button.UseVisualStyleBackColor = true;
            this.Add_Data_Display_button.Click += new System.EventHandler(this.Add_Data_Display_button_Click);
            // 
            // Add_Random_Data_button
            // 
            this.Add_Random_Data_button.Location = new System.Drawing.Point(19, 346);
            this.Add_Random_Data_button.Name = "Add_Random_Data_button";
            this.Add_Random_Data_button.Size = new System.Drawing.Size(186, 59);
            this.Add_Random_Data_button.TabIndex = 6;
            this.Add_Random_Data_button.Text = "加入亂數資料";
            this.Add_Random_Data_button.UseVisualStyleBackColor = true;
            this.Add_Random_Data_button.Click += new System.EventHandler(this.Add_Random_Data_button_Click);
            // 
            // Statistics_Data_button
            // 
            this.Statistics_Data_button.Location = new System.Drawing.Point(19, 411);
            this.Statistics_Data_button.Name = "Statistics_Data_button";
            this.Statistics_Data_button.Size = new System.Drawing.Size(186, 59);
            this.Statistics_Data_button.TabIndex = 7;
            this.Statistics_Data_button.Text = "統計目前資料";
            this.Statistics_Data_button.UseVisualStyleBackColor = true;
            // 
            // Clear_Data_button
            // 
            this.Clear_Data_button.Location = new System.Drawing.Point(19, 476);
            this.Clear_Data_button.Name = "Clear_Data_button";
            this.Clear_Data_button.Size = new System.Drawing.Size(186, 59);
            this.Clear_Data_button.TabIndex = 8;
            this.Clear_Data_button.Text = "清空資料";
            this.Clear_Data_button.UseVisualStyleBackColor = true;
            this.Clear_Data_button.Click += new System.EventHandler(this.Clear_Data_button_Click);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(105, 75);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 31);
            this.Name_textBox.TabIndex = 9;
            // 
            // Chineses_textBox
            // 
            this.Chineses_textBox.Location = new System.Drawing.Point(105, 128);
            this.Chineses_textBox.Name = "Chineses_textBox";
            this.Chineses_textBox.Size = new System.Drawing.Size(100, 31);
            this.Chineses_textBox.TabIndex = 10;
            // 
            // English_textBox
            // 
            this.English_textBox.Location = new System.Drawing.Point(105, 181);
            this.English_textBox.Name = "English_textBox";
            this.English_textBox.Size = new System.Drawing.Size(100, 31);
            this.English_textBox.TabIndex = 11;
            // 
            // Japanese_textBox
            // 
            this.Japanese_textBox.Location = new System.Drawing.Point(105, 234);
            this.Japanese_textBox.Name = "Japanese_textBox";
            this.Japanese_textBox.Size = new System.Drawing.Size(100, 31);
            this.Japanese_textBox.TabIndex = 12;
            // 
            // Add_Random20_button
            // 
            this.Add_Random20_button.Location = new System.Drawing.Point(19, 578);
            this.Add_Random20_button.Name = "Add_Random20_button";
            this.Add_Random20_button.Size = new System.Drawing.Size(186, 59);
            this.Add_Random20_button.TabIndex = 13;
            this.Add_Random20_button.Text = "隨機加入20列資料亂數";
            this.Add_Random20_button.UseVisualStyleBackColor = true;
            this.Add_Random20_button.Click += new System.EventHandler(this.Add_Random20_button_Click);
            // 
            // Display_textBox
            // 
            this.Display_textBox.AllowDrop = true;
            this.Display_textBox.Location = new System.Drawing.Point(240, 75);
            this.Display_textBox.Multiline = true;
            this.Display_textBox.Name = "Display_textBox";
            this.Display_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display_textBox.Size = new System.Drawing.Size(776, 523);
            this.Display_textBox.TabIndex = 14;
            // 
            // StudentScoreStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 661);
            this.Controls.Add(this.Display_textBox);
            this.Controls.Add(this.Add_Random20_button);
            this.Controls.Add(this.Japanese_textBox);
            this.Controls.Add(this.English_textBox);
            this.Controls.Add(this.Chineses_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Clear_Data_button);
            this.Controls.Add(this.Statistics_Data_button);
            this.Controls.Add(this.Add_Random_Data_button);
            this.Controls.Add(this.Add_Data_Display_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("華康少女文字W5(P)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "StudentScoreStatistics";
            this.Text = "StudentScoreStatistics";
            this.Load += new System.EventHandler(this.StudentScoreStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Data_Display_button;
        private System.Windows.Forms.Button Add_Random_Data_button;
        private System.Windows.Forms.Button Statistics_Data_button;
        private System.Windows.Forms.Button Clear_Data_button;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Chineses_textBox;
        private System.Windows.Forms.TextBox English_textBox;
        private System.Windows.Forms.TextBox Japanese_textBox;
        private System.Windows.Forms.Button Add_Random20_button;
        private System.Windows.Forms.TextBox Display_textBox;
    }
}