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
    public partial class CashierForm1 : Form
    {
        public CashierForm1()
        {
            InitializeComponent();
            clear_data();
            

        }

        //單項金額(單價*數量)
        internal int total1;
        internal int total2;
        internal int total3;
        internal int total4;
        //單價
        internal int price1 = 50;
        internal int price2 = 100;
        internal int price3 = 150;
        internal int price4 = 200;
        //數量
        internal int qty1;
        internal int qty2;
        internal int qty3;
        internal int qty4;
        //應付總額
        internal int MaxTotal;

        private void button7_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        //變數初始值
        internal void clear_data()
        {
            //textBox1.Text = null;
            //textBox2.Text = null;
            //textBox3.Text = "0";
            //textBox4.Text = "0";
            //textBox5.Text = "0";
            //textBox6.Text = "0";
            label1.Text = null;
            label3.Text = null;
            label4.Text = null;


            total1 = 0;
            total2 = 0;
            total3 = 0;
            total4 = 0;

            qty1 = 0;
            qty2 = 0;
            qty3 = 0;
            qty4 = 0;

            //discount = 100;
            MaxTotal = 0;
            //ReturnAmt = 0;

            //label1.Visible = false;
            //label2.Visible = false;
            //textBox1.Visible = false;
            //textBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qty1 = qty1 + 1;
            //textBox3.Text = qty1.ToString();
            OrderList(button1.Text + " * 1");
        }

        internal void OrderList(string str)
        {
            //label3.Text = null;

            if (string.IsNullOrWhiteSpace(label4.Text))
            {
                label4.Text = str;
            }
            else
            {
                label4.Text = label4.Text + "\n" + str;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qty2 = qty2 + 1;
            // textBox4.Text = qty2.ToString();
            OrderList(button2.Text + " * 1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qty3 = qty3 + 1;
            //textBox5.Text = qty3.ToString();
            OrderList(button3.Text + " * 1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            qty4 = qty4 + 1;
            //textBox6.Text = qty4.ToString();
            OrderList(button4.Text + " * 1");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            CountAmt();
        }

        internal void CountAmt()
        {
            MaxTotal = (qty1 * price1 + qty2 * price2 + qty3 * price3 + qty4 * price4);
            label1.Text = MaxTotal.ToString();
        }
    }





}
