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
    public partial class Lorn_Report2 : Form
    {
        public Lorn_Report2()
        {
            InitializeComponent();
            this.textBox1.Text = Lorn_Form1.infoft.ToString();
            this.textBox2.Text = Lorn_Form1.infoans.ToString();
        }
    }
}
