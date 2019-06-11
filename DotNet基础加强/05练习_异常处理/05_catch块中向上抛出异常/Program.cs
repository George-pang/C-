using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_catch块中向上抛出异常
{
    class Program
    {
        static void Main(string[] args) //静态方法只能访问静态成员
        {

            try
            {
                M1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("这是再次向上抛出的异常信息：");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void M1() 
        {
            Console.WriteLine("=================");
            try
            {
                M2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("这是向上抛出的异常信息：");
                Console.WriteLine(ex.Message);
                throw;     //继续将该异常向上抛出
            }
            Console.WriteLine("=================");
        }
        private static void M2()
        {
            try
            {
                int m = 10, n = 0;
                Console.WriteLine(m/n);
            }
            catch (Exception)
            {
                Console.WriteLine("捕获了该异常，并且做了相关的处理！");
                throw;    //throw;只能在catch块中使用，表示将该异常向上抛出！！！
            }
        }
    }
}
