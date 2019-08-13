using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace CSharp_Windows._1.表單控制項
{
    
    public partial class OOXX : Form
    {
        /*玩家計分 代數初始變數-------------------------------------------------------50*/
        int SUMO = 0;
        int SUMX = 0;
        //---------------------------------------------------------------------------68



        /*主程式區段------------------------------------------------------------------60*/
        public OOXX()
        {
            InitializeComponent();

            /*文字標籤初始值-------------------------------------------------------50*/
            WinLoseJudg.Text = "判決に勝つか負ける\n\n";
            RightLabel.Text = "0";
            LeftLabel.Text = "0";
            //-------------------------------------------------------------------60


            /*註冊button左右點擊事件--------------------------------------------------50*/
            button1.MouseDown += Button1_MouseDown;
            button2.MouseDown += Button2_MouseDown;
            button3.MouseDown += Button3_MouseDown;
            button4.MouseDown += Button4_MouseDown;
            button5.MouseDown += Button5_MouseDown;
            button6.MouseDown += Button6_MouseDown;
            button7.MouseDown += Button7_MouseDown;
            button8.MouseDown += Button8_MouseDown;
            button9.MouseDown += Button9_MouseDown;
            //----------------------------------------------------------------------70



            /*九宮格控制-------------------------------------------------------50*/
            foreach (Control C in this.panel1.Controls)
            {
                C.Text = " ";
                C.BackColor = Color.Gold;
                C.ForeColor = Color.Black;
                C.MouseDown += C_MouseDown1;
            }
        }
        //-------------------------------------------------------------------60




        /*遊戲主功能------------------------------------------------------------60*/
        private void C_MouseDown1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((Button)sender).Text = "X"; //第一個玩家使用左鍵

            }

            if (e.Button == MouseButtons.Right)
            {
                ((Button)sender).Text = "O"; //第二個玩家使用右鍵
            }
        }
        //----------------------------------------------------------------------70


        /*遊戲主功能 點擊button後 button 的 enabled 關閉----------------------20*/
        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void Button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void Button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void Button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void Button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = false;
            }
        }

        private void Button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button7.Enabled = false;
            }
            else
            {
                button7.Enabled = false;
            }
        }

        private void Button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void Button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button9.Enabled = false;
            }
            else
            {
                button9.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetMouseEventArgs();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            WinLoseJudg.Text = "判決に勝つか負ける\n\n";







        }


        /*輸贏全局判斷式------------------------------------------------------*/
        private void button11_Click(object sender, EventArgs e)
        {

            if (button1.Text == button2.Text && button2.Text == button3.Text)  //123
            {
                if (button1.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button1.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)  //456
            {
                if (button4.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button4.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)  //789
            {
                if (button4.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button4.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)  //147
            {
                if (button1.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                    
                }
                else if (button1.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text) //258
            {
                if ((button2.Text.Substring(0) == "O" && button5.Text.Substring(0) == "O") && button8.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if ((button2.Text.Substring(0) == "X" && button5.Text.Substring(0) == "X") && button8.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }

            if (button3.Text == button6.Text && button6.Text == button9.Text)  //369
            {
                if (button3.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button3.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)  //159
            {
                if (button1.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button1.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)  //357
            {
                if (button3.Text.Substring(0) == "O")
                {
                    WinLoseJudg.Text = "勝者 <O> プレイヤー";
                }
                else if (button3.Text.Substring(0) == "X")
                {
                    WinLoseJudg.Text = "勝者 <X> プレイヤー";
                }
                
            }
            
            if (WinLoseJudg.Text.Substring(0) == "勝者 <O> プレイヤー")
            {
                SUMO = SUMO + 1;
                RightLabel.Text = SUMO.ToString();
            }
            else if (WinLoseJudg.Text.Substring(0) == "勝者 <X> プレイヤー")
            {
                SUMX = SUMX + 1;
                LeftLabel.Text = SUMX.ToString();
            }
            else
            {
                WinLoseJudg.Text = "未定";
            }
        }

        private void 計分消去_Click(object sender, EventArgs e)
        {
            SUMO = 0;
            SUMX = 0;
            RightLabel.Text = "0";
            LeftLabel.Text = "0";
        }

        
    }
    //---------------------------------------------------------------------


    //using System.Windows.Input;
    //void OnMouseDownClickCount(object sender, MouseButtonEventArgs e)
    //{
    //    if (e.ClickCount == 1)
    //    {
    //        ((Button)sender).Text = "X";
    //    }
    //    if (e.ClickCount == 2)
    //    {
    //        ((Button)sender).Text = "O";
    //    }
    //    if (e.ClickCount == 3)
    //    {
    //        ((Button)sender).Text = "X";
    //    }
    //    if (e.ClickCount == 4)
    //    {
    //        ((Button)sender).Text = "O";
    //    }
    //    if (e.ClickCount == 5)
    //    {
    //        ((Button)sender).Text = "X";
    //    }
    //    if (e.ClickCount == 6)
    //    {
    //        ((Button)sender).Text = "O";
    //    }
    //    if (e.ClickCount == 7)
    //    {
    //        ((Button)sender).Text = "X";
    //    }
    //    if (e.ClickCount == 8)
    //    {
    //        ((Button)sender).Text = "O";
    //    }
    //    if (e.ClickCount == 9)
    //    {
    //        ((Button)sender).Text = "X";
    //    }
    //}












}
