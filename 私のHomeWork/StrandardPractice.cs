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
    public partial class StrandardPractice : Form
    {
        public StrandardPractice()
        {
            InitializeComponent();
        }
        internal int a = 1, b = 89, c = 56, d = 7, ab = 12, ac = 18, ad = 22;

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_9x9 NewFrm_9x9 = new Frm_9x9();
            NewFrm_9x9.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String number = "100";
            int fromBase = 10;
            int toBase = 2;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

            DisplayLabel.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //SUM int
            int SUM;
            SUM = a + b + c + d + ab + ac + ad;
            Console.WriteLine(SUM);
            MessageBox.Show("SUM =" + SUM, "SUM");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int i = 5;

            for (int j = 0; j < i; j++)
            {


                //DisplayLabel.Text = 
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] ram = { 0, 0, 0, 0, 0, 0 };
            int i = 0;
            Random r = new Random();
            int n;
            while (i < 6)
            {
                n = r.Next(1, 43);

                if (!ram.Contains(n))
                {
                    ram[i] = n;
                    i += 1;
                }

               
            LottoLabel1.Text = ram[0].ToString();
            LottoLabel2.Text = ram[1].ToString();
            LottoLabel3.Text = ram[2].ToString();
            LottoLabel4.Text = ram[3].ToString();
            LottoLabel5.Text = ram[4].ToString();
            LottoLabel6.Text = ram[5].ToString();
            }
        
            
        }

        

        internal string sa = "qwer", sb = "asdf", sc = "zxcv", sd = "qwe", sab = "hjklp";

        private void button14_Click(object sender, EventArgs e)
        {
            //String 最長的字串
            var Longstr = new List<string> { "qwer", "asdf", "zxcv", "qwe", "hjklp"};
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Min int
            int Min = int.MaxValue;
            if (a < Min)
               Min = a;
            if (b < Min)
               Min = b;
            if (c < Min)
               Min = c;
            if (d < Min)
               Min = d;
            if (ab < Min)
               Min = ab;
            if (ac < Min)
               Min = ac;
            if (ad < Min)
               Min = ad;
            Console.WriteLine(Min);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                int[] a = new int[20];
                Random rnd = new Random();
                
                for (int i = 0; i < 20; i++)
                {
                    a[i] = rnd.Next(1, 100);
                }
                //检查奇数、偶数的个数
                int 單數 = 0, 雙數 = 0;
                for (int i = 0; i < 20; i++)
                {
                    if ((a[i] % 2) == 0)
                    {
                          單數++;
                    }
                    else
                    {
                           雙數++;
                    }
                }
            //DisplayLabel.Text = a[i] % 2;
            }

        }

        
    }



