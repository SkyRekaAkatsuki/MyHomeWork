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
    public struct StudentNewScore
    {
        public string Name;
        public int Chineses;
        public int English;
        public int Japanese;
    }
    public class SSCORE
    {
        public static string GetRandomStringByFileName(int length, int v)
        {
            var str = Path.GetRandomFileName().Replace(".", "");
            return str.Substring(0, length);
        }



        internal static void RandomScore()
        {
            Random R = new Random();
            string Random_Data_Name = SSCORE.GetRandomStringByFileName(4, 100);  //類別.方法
            //System.IO.Path類別所提供的方法
            //使用GetRandomFileName()方法
            //static return

            //Add1((i + 1), R.Next(60, 101), R.Next(60, 101), R.Next(60, 101));
            int[] arr = new int[3];
            for (int i = 0; i <= arr.GetLength(0) - 1; i++)
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
        }
    }
}
