using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace 私のHomeWork
{
    public partial class Lorn_Form1 : Form
    {
        
        

        //protected static object f;

        public Lorn_Form1()
        {
            InitializeComponent();
        }
        internal static double buy, x, y, a, z, b, c, buy2, x2, y2, a2, z2, b2, c2;
        internal static double infoft;
        internal static double infoans;
        public double buy_ans;



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void 購買價格_TextChanged(object sender, EventArgs e)
        {
            String buy = "";
            int.TryParse(buy, out int num);
            Console.Write(num);


}

        internal void Form1_Load(object sender, EventArgs e)
        {
            double buy = double.Parse(購買價格.Text);
            double x = double.Parse(頭期款.Text);
            double y = double.Parse(利率百分比.Text);
            double a = double.Parse(期限年.Text);
            double z = (y / 12);
            double b = a * 12;
            double c = buy - x;
            //string strx = ans.ToString();
            double ft = Financial.Pmt(z / 100, b, -c);
            string strx1 = ft.ToString();

            infoft = ft;

            

            double buy2 = double.Parse(購買價格.Text);
            double x2 = double.Parse(頭期款.Text);
            double y2 = double.Parse(利率百分比.Text);
            double a2 = double.Parse(期限年.Text);
            double z2 = (y / 12);
            double b2 = a * 12;
            double c2 = buy - x;
            double h2 = (y / 100) + 1;
            //string strx = ans.ToString();
            double ans = (buy - x) * h2;
            string strx2 = ans.ToString();
             infoans = ans;
        }

        internal void PTM月付款_Click(object sender, EventArgs e)
        {
            double buy = double.Parse(購買價格.Text);
            double x = double.Parse(頭期款.Text);
            double y = double.Parse(利率百分比.Text);
            double a = double.Parse(期限年.Text);
            double z = (y / 12);
            double b = a * 12;
            double c = buy - x;
            //string strx = ans.ToString();
            double ft = Financial.Pmt(z / 100, b, -c);
            string strx1 = ft.ToString();
            MessageBox.Show(strx1,"月付款");

            






            //double buy = double.Parse(購買價格.Text);
            //double x = double.Parse(頭期款.Text);
            //double y = double.Parse(利率百分比.Text);
            //double z = (y / 100)+1;  //利率進程式為 EX: 10% =>10 所以要除100
            //double year = double.Parse(期限年.Text);
            //double ans = (((buy-x)*year*12)/year);
            //string strx = ans.ToString();
            //MessageBox.Show("月付款: " + strx,"月付款");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // double d = double.Parse( textBox4.Text);
        }

        internal void 總付款_Click(object sender, EventArgs e)
        {
             
            double buy= double.Parse(購買價格.Text);
            double x = double.Parse(頭期款.Text);
            double y = double.Parse(利率百分比.Text);
            double a = double.Parse(期限年.Text);
            double z = (y / 12);
            double b = a * 12;
            double c = buy - x;
            double h = (y/100)+1;
            //string strx = ans.ToString();
            double ans = (buy - x) *h ;
            string strx2 = ans.ToString();
            MessageBox.Show(strx2,"總付款");
            

            // double ans = (buy - x) * z;
            //string strx = ans.ToString();
            //MessageBox.Show("總付款: " + strx,"總付款");

            //object sprintf = (ans);




        }

        private void 頭期款_TextChanged(object sender, EventArgs e)
        {

        }

        private void 期限年_TextChanged(object sender, EventArgs e)
        {

        }

        private void 利率百分比_TextChanged(object sender, EventArgs e)
        {

        }

        public void Email_Click(object sender, EventArgs e)
        {
            
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            String buy = "";
            MessageBox.Show(購買價格.Text);

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Lorn_Report2 r = new Lorn_Report2();
            r.Show();
        }
    }
}
