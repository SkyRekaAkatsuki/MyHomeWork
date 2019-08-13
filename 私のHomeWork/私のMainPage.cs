using CSharp_Windows._1.表單控制項;
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
using 私のHomeWork.應用程序;
using 私のHomeWork.猜數字;

namespace 私のHomeWork
{
    public partial class 私のMainPage : Form
    {
        //DataGridView.Anchor =
        //    AnchorStyles.Bottom |
        //    AnchorStyles.Right |
        //    AnchorStyles.Top |
        //    AnchorStyles.Left;
        
        public 私のMainPage()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Lorn_Form1 NewLornForm1 = new Lorn_Form1( );
            NewLornForm1.Show( );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierForm1 NewCashierForm1 = new CashierForm1();
            NewCashierForm1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentScore NewStudentScore = new StudentScore( );
            NewStudentScore.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentScoreStatisticsGeneric NewStudentScoreStatistics = new StudentScoreStatisticsGeneric();
            NewStudentScoreStatistics.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StrandardPractice NewStrandardPractice = new StrandardPractice();
            NewStrandardPractice.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UI_MainPage NewUI_MainPage = new UI_MainPage();
            NewUI_MainPage.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm猜數字 NewFrm猜數字 = new Frm猜數字();
            NewFrm猜數字.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PictureViewer NewPictureViewer = new PictureViewer();
            NewPictureViewer.Show();
        }
    }
}
