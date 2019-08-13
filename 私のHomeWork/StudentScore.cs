using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 私のHomeWork
{
    public partial class StudentScore : Form
    {
        /*宣告計算試所用的變數*/
        internal int PumenpinScore, BaoshijingScore, MettaScore;

        public StudentScore()
        {
            InitializeComponent();
            
          
            /*強制擴大 textBox 大小*/
            { 
                NameBox.AutoSize = false;
                NameBox.Height = 24;
                PumenpinBox.AutoSize = false;
                PumenpinBox.Height = 24;
                BaoshijingBox.AutoSize = false;
                BaoshijingBox.Height = 24;
                MettaBox.AutoSize = false;
                MettaBox.Height = 24;
                TotalScoreBox.AutoSize = false;
                TotalScoreBox.Height = 24;
                AvgScoreBox.AutoSize = false;
                AvgScoreBox.Height = 24;
                TopScoreBox.AutoSize = false;
                TopScoreBox.Height = 24;
                LowScoreBox.AutoSize = false;
                LowScoreBox.Height = 24;
            }
           
        }

        private void StudentScore_Load(object sender, EventArgs e)
        {
            
        }

        
         ScoreData SD;

        private void TopLowScorebutton_Click(object sender, EventArgs e)
        {
            /*計算最高分*/ /*int max3 = Math.Max(x, Math.Max(y, z));*/
            TopScoreBox.Text = Math.Max(SD.普門品_得分, Math.Max(SD.寶石經_得分, SD.慈經_得分)).ToString();

            /*計算最低分*/ /*int min3 = Math.Max(x, Math.Max(y, z));*/
            LowScoreBox.Text = Math.Min(SD.普門品_得分, Math.Min(SD.寶石經_得分, SD.慈經_得分)).ToString();
        }

        private void AddDatabutton_Click(object sender, EventArgs e)
        {
            SD.姓名 = NameBox.Text;
            SD.普門品_得分 = int.Parse(PumenpinBox.Text);
            SD.寶石經_得分 = int.Parse(BaoshijingBox.Text);
            SD.慈經_得分 = int.Parse(MettaBox.Text);

        }

        internal void TotalAvgScorebutton_Click(object sender, EventArgs e)
        {
            /*將計算用的變數加入數值*/
            PumenpinScore = SD.普門品_得分;
            BaoshijingScore = SD.寶石經_得分;
            MettaScore = SD.慈經_得分;

            /*計算總分*/
            /*textBox3.Text = ((Convert.ToDouble(textBox1.Text)) + (Convert.ToDouble(textBox2.Text))).ToString();*/
            TotalScoreBox.Text = ((Convert.ToDouble(PumenpinScore))
                                                  + (Convert.ToDouble(BaoshijingScore))
                                                  + (Convert.ToDouble(MettaScore))).ToString();

            /*計算平均*/
            AvgScoreBox.Text = (Convert.ToDouble(TotalScoreBox.Text)/3).ToString();

            



            // MessageBox.Show("" + SD.普門品_得分);

            /*Arealabel 列表顯示*/
            Arealabel.Text = "大德姓名"+ SD.姓名+"\n"
                                       + "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////////////////// " + "\n"+"\n"
                                       +"普門品 得分" + SD.普門品_得分+"\n"+ "寶石經_得分"
                                       + SD.寶石經_得分+"\n"+ "慈經_得分" + SD.慈經_得分;
        }
    }
}
