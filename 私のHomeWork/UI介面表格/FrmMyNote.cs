using CSharp_Windows._1.表單控制項;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Windows._2.功能表_工具列_對話方塊
{
    public partial class FrmMyNote : Form
    {
        public FrmMyNote()
        {
            InitializeComponent();

            this.textBox1.ScrollBars = ScrollBars.Both;
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader NewStreamReader = new StreamReader(@"E:\SQL Password.txt");
            this.textBox1.Text = NewStreamReader.ReadToEnd();
            NewStreamReader.Close();
            NewStreamReader.Dispose();
            this.toolStripLabel1.Text = "Password SQL.txt";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStrip3.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.WordWrap = !this.textBox1.WordWrap;
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.ToUpper();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Blue;
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout NewAbout = new FrmAbout();
            NewAbout.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
