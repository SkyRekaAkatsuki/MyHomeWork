using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Windows._1.表單控制項
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            
            InitializeComponent();
            label1.Text = $"Version:{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
