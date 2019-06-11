using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_异常处理代码执行顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1111111111111111");
                int n = 10, m = 0;
                Console.WriteLine(n / m); //异常
                Console.WriteLine("2222222222222222");//异常后面的代码不执行
            }
            catch (Exception)
            {
                Console.WriteLine("3333333333333333");
            }
            finally {
                //如果希望代码无论如何都要执行，那么则一定要将代码放入finally块中。
                //1、当catch块有无法捕获到的异常时，程序会崩溃，但在崩溃前会执行finally块中的代码,而finally块后的代码不会执行。
                //2、如果在catch块中又引发了异常，在异常引发前会执行finally块中的代码，而finally块后的代码不会执行。
                //3、如果catch块中有return语句，在return之前会执行finally块中的代码，而finally块后的代码不会执行。
                Console.WriteLine("4444444444444444");
            }
            Console.WriteLine("55555555555555555");


            Console.ReadKey();
        }
    }
}
