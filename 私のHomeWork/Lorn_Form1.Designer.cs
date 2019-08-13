namespace 私のHomeWork
{
    partial class Lorn_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lorn_Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.頭期款 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.利率百分比 = new System.Windows.Forms.TextBox();
            this.總付款 = new System.Windows.Forms.Button();
            this.BTN月付款 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.期限年 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.購買價格 = new System.Windows.Forms.TextBox();
            this.轉型 = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(32, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "頭期款";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // 頭期款
            // 
            this.頭期款.Location = new System.Drawing.Point(180, 95);
            this.頭期款.Margin = new System.Windows.Forms.Padding(4);
            this.頭期款.Name = "頭期款";
            this.頭期款.Size = new System.Drawing.Size(148, 29);
            this.頭期款.TabIndex = 64;
            this.頭期款.Text = "100000";
            this.頭期款.TextChanged += new System.EventHandler(this.頭期款_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(32, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 63;
            this.label5.Text = "利率 (%)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // 利率百分比
            // 
            this.利率百分比.Location = new System.Drawing.Point(180, 224);
            this.利率百分比.Margin = new System.Windows.Forms.Padding(4);
            this.利率百分比.Multiline = true;
            this.利率百分比.Name = "利率百分比";
            this.利率百分比.Size = new System.Drawing.Size(148, 36);
            this.利率百分比.TabIndex = 62;
            this.利率百分比.Text = "10";
            this.利率百分比.TextChanged += new System.EventHandler(this.利率百分比_TextChanged);
            // 
            // 總付款
            // 
            this.總付款.Location = new System.Drawing.Point(853, 432);
            this.總付款.Margin = new System.Windows.Forms.Padding(4);
            this.總付款.Name = "總付款";
            this.總付款.Size = new System.Drawing.Size(112, 34);
            this.總付款.TabIndex = 61;
            this.總付款.Text = "總付款";
            this.總付款.UseVisualStyleBackColor = true;
            this.總付款.Click += new System.EventHandler(this.總付款_Click);
            // 
            // BTN月付款
            // 
            this.BTN月付款.Location = new System.Drawing.Point(837, 390);
            this.BTN月付款.Margin = new System.Windows.Forms.Padding(4);
            this.BTN月付款.Name = "BTN月付款";
            this.BTN月付款.Size = new System.Drawing.Size(128, 34);
            this.BTN月付款.TabIndex = 60;
            this.BTN月付款.Text = "PMT (月付款)";
            this.BTN月付款.UseVisualStyleBackColor = true;
            this.BTN月付款.Click += new System.EventHandler(this.PTM月付款_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(32, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "期限 (年)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // 期限年
            // 
            this.期限年.Location = new System.Drawing.Point(180, 161);
            this.期限年.Margin = new System.Windows.Forms.Padding(4);
            this.期限年.Name = "期限年";
            this.期限年.Size = new System.Drawing.Size(148, 29);
            this.期限年.TabIndex = 58;
            this.期限年.Text = "4";
            this.期限年.TextChanged += new System.EventHandler(this.期限年_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "購買價格";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // 購買價格
            // 
            this.購買價格.Location = new System.Drawing.Point(180, 32);
            this.購買價格.Margin = new System.Windows.Forms.Padding(4);
            this.購買價格.Name = "購買價格";
            this.購買價格.Size = new System.Drawing.Size(148, 29);
            this.購買價格.TabIndex = 56;
            this.購買價格.Text = "3000000";
            this.購買價格.TextChanged += new System.EventHandler(this.購買價格_TextChanged);
            // 
            // 轉型
            // 
            this.轉型.Location = new System.Drawing.Point(853, 518);
            this.轉型.Margin = new System.Windows.Forms.Padding(4);
            this.轉型.Name = "轉型";
            this.轉型.Size = new System.Drawing.Size(112, 34);
            this.轉型.TabIndex = 55;
            this.轉型.Text = "轉型";
            this.轉型.UseVisualStyleBackColor = true;
            this.轉型.Click += new System.EventHandler(this.button4_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(853, 474);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(112, 34);
            this.Email.TabIndex = 54;
            this.Email.Text = "Email";
            this.Email.UseVisualStyleBackColor = true;
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 66;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.頭期款);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.利率百分比);
            this.Controls.Add(this.總付款);
            this.Controls.Add(this.BTN月付款);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.期限年);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.購買價格);
            this.Controls.Add(this.轉型);
            this.Controls.Add(this.Email);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Frm貸款";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox 頭期款;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox 利率百分比;
        private System.Windows.Forms.Button 總付款;
        private System.Windows.Forms.Button BTN月付款;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 期限年;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox 購買價格;
        private System.Windows.Forms.Button 轉型;
        private System.Windows.Forms.Button Email;
        private System.Windows.Forms.Button button1;
    }
}

