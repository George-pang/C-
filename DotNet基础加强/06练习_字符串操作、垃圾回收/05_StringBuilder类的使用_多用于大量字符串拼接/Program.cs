using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StringBuilder类的使用_多用于大量字符串拼接
{
    class Program
    {
        static void Main(string[] args)
        {
            #region string拼接大量字符串

            string[] lines = File.ReadAllLines("salary.txt", Encoding.Default);
            string msg = string.Empty; //表示空字符串
            Stopwatch watch = new Stopwatch(); //对程序部分代码进行计时(ms级别)
            watch.Start(); //开始计时  
            foreach (var item in lines)
            {
                msg += item;
            }
            watch.Stop();//结束计时 
            Console.WriteLine(watch.Elapsed);  //获取运行时间间隔  
            //Console.WriteLine(msg);
            Console.ReadKey();

            #endregion

            #region StringBuilder拼接大量字符串

            string[] lines2 = File.ReadAllLines("salary.txt", Encoding.Default);
            StringBuilder sb = new StringBuilder(); //表示空字符串
            Stopwatch watch2 = new Stopwatch(); //对程序部分代码进行计时(ms级别)
            watch2.Start(); //开始计时  
            foreach (var item in lines2)
            {
                sb.Append(item); //StringBuilder使用Append方法进行拼接
            }
            watch2.Stop();//结束计时 
            Console.WriteLine(watch2.Elapsed);  //获取运行时间间隔 ----拼接大量字符串时，StringBuilder的效率要高得多
            //Console.WriteLine(msg);
            Console.ReadKey();

            #endregion

        }
    }
}
