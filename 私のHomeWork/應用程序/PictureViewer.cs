using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 私のHomeWork.應用程序
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void 開啟目錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog NewOpenFileDialog = new OpenFileDialog();
            NewOpenFileDialog.Filter = "jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (NewOpenFileDialog.ShowDialog() == DialogResult.OK && NewOpenFileDialog.Filter.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(NewOpenFileDialog.FileName);
            }
                
        }

        private void 存我們ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog NewSaveFileDialog = new SaveFileDialog();
            NewSaveFileDialog.Filter = "jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";
            
            if(NewSaveFileDialog.ShowDialog()==DialogResult.OK && NewSaveFileDialog.FileName.Length >0)
            {
                pictureBox1.Image.Save(NewSaveFileDialog.FileName);
            }
        }

        private void 走你ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
