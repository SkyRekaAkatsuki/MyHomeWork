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
    public partial class Frm_9x9 : Form
    {
        public Frm_9x9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //string format =
            //"{0,2}  {1,2}   ";
            label1.Text = "9*9 Frm\n==================\n";
            for (int j = 1; j < 10; j++)
            {
                label1.Text += $"{"\r\n"}";
                for (int i = 2; i < 10; i++)
                {
                    label1.Text += $"{i}*{j}={(j * i),-2}    ";
                    //label1.Text += string.Format(format, ("i*j="), i * j);
                }

            }
        }
    }
}
