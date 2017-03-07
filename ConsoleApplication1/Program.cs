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

            Console.WriteLine("請輸入第一個數字");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入第二個數字");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", number1, number2, number1 + number2);
        }
    }
}