using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int? age = null;

            //數字大轉小
            double a = 3.1415926f;
            float b = (float)a;

            //數字小轉大
            float c = 3.1415f;
            double d = c;

            float e = 3.1415f;
            double f = (double)e;

            //文字轉數字
            string s = "100.3";
            float sf = float.Parse(s);

            //數字轉文字
            float t = 3.1415926f;
            string u = t.ToString();

            //int number1 = 0; int number2 = 0;
            //Console.WriteLine("請輸入第一個數字");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("請輸入第二個數字");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);

            int number1 = 0;
            int number2 = 0;
            Console.Write("請輸入第一個數字:");
            try
            {
                number1 = int.Parse(Console.ReadLine());
            }
            catch (Exception warning)
            {
                Console.WriteLine("第一個數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + warning.ToString());
                return;
            }

            Console.Write("請輸入第二個數字:");
            try
            {
                number2 = int.Parse(Console.ReadLine());
            }
            catch (Exception warning)
            {
                Console.WriteLine("第二個數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + warning.ToString());
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }
    }
}