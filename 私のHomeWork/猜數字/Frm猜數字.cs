using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 私のHomeWork.猜數字
{
    public partial class Frm猜數字 : Form
    {
        public Frm猜數字()
        {
            InitializeComponent();
            Random r = new Random();  //建立亂數
            pcRandomNUM = r.Next(1, 1000);
            label2.Text = $"請猜數字範圍 0 < ? < 1000";

        }
        int typeNUM;  //猜的數字
        int pcRandomNUM;  //Random的數字
        int minNUM = 0;    //最小值
        int maxNUM = 1000;  //最大值
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = $"猜數字範圍 {minNUM} < ? < {maxNUM}";
            typeNUM = int.Parse(guessbox.Text);
            if (typeNUM >= minNUM && typeNUM < maxNUM)
            {
                if (typeNUM == pcRandomNUM)
                {
                    label2.Text = "恭喜你猜中了";
                    
                }
                else if (typeNUM > pcRandomNUM)
                {
                    
                    maxNUM = typeNUM; //將錯誤的數字指定給最大值
                    label2.Text = "在小一點"+$"\t{minNUM} < ? < {maxNUM}";                  
                }
                else if (typeNUM < pcRandomNUM)
                {
                    
                    minNUM = typeNUM; //將錯誤的數字指定給最小值
                    label2.Text = "在大一點"+$"\t{minNUM} < ? < {maxNUM}";                  
                }

            }
            else
            {
                label2.Text = $"猜數字範圍 {minNUM} < ? < {maxNUM}";
            }




        }
        
            private void button2_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            //pcRandomNUM = r.Next(1, 100);
            //MessageBox.Show("" + pcRandomNUM);
        }
    }
}
