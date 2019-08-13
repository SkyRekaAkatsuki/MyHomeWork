using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 私のHomeWork.UI介面表格
{
    public partial class 私のHomeWork : Form
    {
        public 私のHomeWork()
        {
            InitializeComponent();

            this.MouseDown += ScreenProtect_MouseDown;
            this.MouseMove += ScreenProtect_MouseMove;
        }
        int StarX;
        int StarY;
        bool StarT = true;
        private void ScreenProtect_MouseMove(object sender, MouseEventArgs e)
        {
            if (StarT)
            {
                StarX = e.X;
                StarY = e.Y;

                StarT = false;

            }

            {
                //Math.Abs​​(eX-StarX）;
                if ((Math.Abs​​(e.X - StarX) > 100) || (Math.Abs​​(e.Y - StarY) > 100))

                    this.Close();
            }

        }

    

        private void ScreenProtect_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();

        }
        bool right = true;
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right)
            {
                this.label1.Left = this.label1.Left + 15;
                this.label2.Left = this.label1.Left + 15;
            }
            else
            {
                this.label1.Left = this.label1.Left - 15;
                this.label2.Left = this.label1.Left - 15;
            }

            if (this.label1.Left <=0)
            {
                this.label1.Left = 0;
                right = true;
            }

            if (this.label1.Right > this.Width)
            {
                right = false;
            }

            if (this.label2.Left <= 0)
            {
                this.label2.Left = 0;
                right = true;
            }

            if (this.label2.Right > this.Width)
            {
                right = false;
            }
        }
    }
}
