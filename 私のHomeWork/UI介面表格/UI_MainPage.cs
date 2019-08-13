
using CSharp_Windows._1.表單控制項;
using CSharp_Windows._2.功能表_工具列_對話方塊;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 私のHomeWork.UI介面表格;

namespace 私のHomeWork.UI介面表格
{
    public partial class UI_MainPage : Form
    {
        public UI_MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OOXX NewOOXX = new OOXX();
            NewOOXX.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            私のHomeWork NewFrmScreenProtect = new 私のHomeWork();
            NewFrmScreenProtect.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMyNote NewFrmMyNote = new FrmMyNote();
            NewFrmMyNote.Show();
        }
    }
}
