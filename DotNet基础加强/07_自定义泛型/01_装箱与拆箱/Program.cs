using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_装箱与拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 装箱和拆箱

            //装箱:将值类型转为引用类型时，发生装箱;引用类型转为值类型时，发生拆箱
            int m=10;
            object o = m;   //发生装箱
            int n = (int)o; //发生拆箱---装箱时是什么类型，拆箱后也只能是什么类型

            #endregion

            #region 装箱和拆箱的性能问题

            //ArrayList arr = new ArrayList();
            //Stopwatch stop = new Stopwatch();
            //stop.Start();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    arr.Add(i); //发生了装箱 形参是Object类型，实参用的int类型
            //}
            //stop.Stop();
            //Console.WriteLine(stop.Elapsed);
            //Console.ReadKey();

            List<int> arrList = new List<int>();
            Stopwatch stop2 = new Stopwatch();
            stop2.Start();
            for (int i = 0; i < 1000000; i++)
            {
                arrList.Add(i); //未发生装箱
            }
            stop2.Stop();
            Console.WriteLine(stop2.Elapsed);
            Console.ReadKey();
              
            #endregion


        }
    }
}
