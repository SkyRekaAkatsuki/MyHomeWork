using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace 私のHomeWork
{
    public partial class StudentScoreStatistics : Form
    {
        
        public StudentScoreStatistics()
        {
            InitializeComponent();
            
        }

        /*設定欄位顯示*/
        internal string format = 
            "{0,6}\t{1,6}\t{2,6}\t{3,6}\t{4,6}\t{5,6}\t{6,6}\t{7,6}{8,6}";
        internal void StudentScoreStatistics_Load(object sender, EventArgs e)
        {
            Display_textBox.Text += string.Format(format, "Name", "中文", "英文", "日文", "最高分", "最低分", "平均值", "總和", Environment.NewLine);
            
        }
        //----------------------------------------------------------------------------------------------------



        /*StudentScoreStatisticsUtility  類別互傳值*/
        private StudentNewScore Add1;
        private int i = 0;
        //----------------------------------------------------------------------------------------------------

        /*加入上方資料並顯示按鈕用變數*/
        public int Chineses;
        public int English;
        public int Japanese;
        //----------------------------------------------------------------------------------------------------

        /*AddData 用的變數*/
        private double ChinesesSet;
        private double EnglishSet;
        private double JapaneseSet;
        //----------------------------------------------------------------------------------------------------


        /*宣告統計用變數*/
        int MAXScore;
        int MINScore;
        int AVG;
        int SUM;
        //----------------------------------------------------------------------------------------------------





        //----------------------------------------------------------------------------------------------------
        internal void Add_Data_Display_button_Click(object sender, EventArgs e)
        {
            /*Snew 新的學生資料*/
            Add1 = new StudentNewScore()
            {
                Name = Name_textBox.Text,
                Chineses = int.Parse(Chineses_textBox.Text),
                English = int.Parse(English_textBox.Text),
                Japanese = int.Parse(Japanese_textBox.Text)
            };
            AddData();
            i = i + 1;
        }
        //----------------------------------------------------------------------------------------------------






        //----------------------------------------------------------------------------------------------------
        //internal void AddRandom()
        //{
        //    string name;
        //    int ChinesesS;
        //    int EnglishS;
        //    int JapaneseS;

        //}
        //----------------------------------------------------------------------------------------------------






        //----------------------------------------------------------------------------------------------------    
        internal void AddData()
        {
            //ChinesesSet = ChinesesSet + Add1.Chineses;
            //EnglishSet = EnglishSet + Add1.English;
            //JapaneseSet = JapaneseSet + Add1.Japanese;


            /*int max3 = Math.Max(x, Math.Max(y, z))*/
            int Max3 = Math.Max(Add1.Chineses, Math.Max(Add1.English, Add1.Japanese));
            /*int max3 = Math.Min(x, Math.Min(y, z))*/
            int Min3 = Math.Min(Add1.Chineses, Math.Min(Add1.English, Add1.Japanese));


            MAXScore = Max3;
            MINScore = Min3;
            AVG = (Add1.Chineses + Add1.English + Add1.Japanese) / 3;
            SUM = Add1.Chineses + Add1.English + Add1.Japanese;

            Display_textBox.Text = 
                Display_textBox.Text + string.Format(format, Add1.Name, Add1.Chineses, Add1.English, Add1.Japanese, MAXScore, MINScore, AVG, SUM, Environment.NewLine);
        }
        //----------------------------------------------------------------------------------------------------






        //----------------------------------------------------------------------------------------------------
        internal void Clear_Data_button_Click(object sender, EventArgs e)
        {
            Display_textBox.Text = null;

            Display_textBox.Text += string.Format(format, "Name", "中文", "英文", "日文", "最高分", "最低分", "平均值", "總和", Environment.NewLine);
        }
        //----------------------------------------------------------------------------------------------------







        //----------------------------------------------------------------------------------------------------
        Random R = new Random();
        private void Add_Random_Data_button_Click(object sender, EventArgs e)
        {
            string Random_Data_Name = SSCORE.GetRandomStringByFileName(4,100);  //類別.方法
            //System.IO.Path類別所提供的方法
            //使用GetRandomFileName()方法
            //static return

            //Add1((i + 1), R.Next(60, 101), R.Next(60, 101), R.Next(60, 101));
            int[] arr = new int[3];
            for (int i = 0; i <= arr.GetLength(0)-1; i++)
            {
                arr[i] = R.Next(0, 101);

            }
            /*
            EX:
            arr[0]= 50;
            arr[1]= 90;
            arr[2]= 70;
            */
            //int Min3 = int.MaxValue;   //最小值 MaxValue = 2147483647
            //int Max3 = int.MinValue;   //最大值 MaxValue = -2147483648
            int Min3 = 101; /*要比較出最小值用的初始變數值*/
            int Max3 = -1;   /*要比較出最大值用的初始變數值*/
            for (int i = 0; i <= arr.GetLength(0)-1; i++)
            {
                if (arr[i] > Max3/*0*/)  //從 arr[0]的值開始比較  
                {
                    Max3 = arr[i];//求最大值
                }
                if (arr[i] < Min3/*101*/)//求最小值，每次都是和（比較過的所有）在做比較，而不是兩兩作比較
                {
                    Min3 = arr[i];
                }
            }
            /*if (arr[i] > Max3) 一、50 > 0，true，arr[i]值為50 */
            /*if (arr[i] < Min3) 一、50 < 101，true，arr[i]值為50 */
            /*if (arr[i] > Max3) 二、90 > 50，true，arr[i]值為90 */
            /*if (arr[i] < Min3) 二、90 < 50，false，arr[i]值為50*/
            /*if (arr[i] > Max3) 三、70 > 90，false，arr[i]值為90*/  //---->Max3=90
            /*if (arr[i] < Min3) 三、70 < 50，false，arr[i]值為50*/  //---->Min3=50


            /*int max3 = Math.Max(x, Math.Max(y, z))*/
            //int Max3 = Math.Max(arr[0], arr[1], arr[2]);

            /*int max3 = Math.Min(x, Math.Min(y, z))*/
            MAXScore = Max3;
            MINScore = Min3;
            SUM = arr[0] + arr[1] + arr[2];
            AVG = SUM / 3;
            

            Display_textBox.Text =
                Display_textBox.Text + string.Format(format, Random_Data_Name, arr[0], arr[1], arr[2], MAXScore, MINScore, AVG, SUM, Environment.NewLine);
        }
        //----------------------------------------------------------------------------------------------------




        //----------------------------------------------------------------------------------------------------
        internal void Add_Random20_button_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= 20; j++)  /*迴圈 1 row 亂數資料輸入 做20次*/ 
            {
                string Random_Data_Name = SSCORE.GetRandomStringByFileName(4, 100);
                //System.IO.Path類別所提供的方法
                //使用GetRandomFileName()方法
                //static return
                int[] arr = new int[3];
                for (int i = 0; i <= arr.GetLength(0) - 1; i = i + 1)
                {
                    arr[i] = R.Next(0, 101);
                }

                /*
                EX:
                arr[0]= 50;
                arr[1]= 90;
                arr[2]= 70;
                */
                //int Min3 = int.MaxValue;   //最小值 MaxValue = 2147483647
                //int Max3 = int.MinValue;   //最大值 MaxValue = -2147483648
                int Min3 = 101; /*要比較出最小值用的初始變數值*/
                int Max3 = -1;   /*要比較出最大值用的初始變數值*/
                for (int i = 0; i <= arr.GetLength(0) - 1; i++)
                {
                    if (arr[i] > Max3/*0*/)  //從 arr[0]的值開始比較  
                    {
                        Max3 = arr[i];//求最大值
                    }
                    if (arr[i] < Min3/*101*/)//求最小值，每次都是和（比較過的所有）在做比較，而不是兩兩作比較
                    {
                        Min3 = arr[i];
                    }
                }
                /*if (arr[i] > Max3) 一、50 > 0，true，arr[i]值為50 */
                /*if (arr[i] < Min3) 一、50 < 101，true，arr[i]值為50 */
                /*if (arr[i] > Max3) 二、90 > 50，true，arr[i]值為90 */
                /*if (arr[i] < Min3) 二、90 < 50，false，arr[i]值為50*/
                /*if (arr[i] > Max3) 三、70 > 90，false，arr[i]值為90*/  //---->Max3=90
                                                                   /*if (arr[i] < Min3) 三、70 < 50，false，arr[i]值為50*/  //---->Min3=50


                /*int max3 = Math.Max(x, Math.Max(y, z))*/
                //int Max3 = Math.Max(arr[0], arr[1], arr[2]);

                /*int max3 = Math.Min(x, Math.Min(y, z))*/
                MAXScore = Max3;
                MINScore = Min3;
                SUM = arr[0] + arr[1] + arr[2];
                AVG = SUM / 3;


                Display_textBox.Text =
                Display_textBox.Text + string.Format(format, Random_Data_Name, arr[0], arr[1], arr[2], MAXScore, MINScore, AVG, SUM, Environment.NewLine);
            }
            
        }
        //----------------------------------------------------------------------------------------------------





    }

}



        
 

