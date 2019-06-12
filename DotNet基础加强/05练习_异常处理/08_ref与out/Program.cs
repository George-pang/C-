using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ref与out
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 3000;
            Test1(ref money);//ref参数在使用前必须赋值
            Test2(ref money);
            Console.WriteLine(money);
            Console.WriteLine();

            int m = 100;
            M1(out m); //out参数无法接收传递进来变量的值，只能对传递进来的变量进行赋值
            Console.WriteLine(m);
            int a;
            int b;
            int res = M2(out a, out b);
            Console.WriteLine("out参数用于多个返回值的场景");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(res);
            Console.WriteLine();

            Console.WriteLine("out参数实例");
            string str = "abc";
            int result;
            if (int.TryParse(str, out result))
            {
                Console.WriteLine("转换成功！结果为：{0}", result);
            }
            else
            {
                Console.WriteLine("转换失败！结果为：{0}", result); //int.TryParse转换失败时，out参数变量result的值为0
            }

            Console.ReadKey();
        }

        //ref参数
        static void Test1(ref int m)
        {
            m = m + 300;
        }
        static void Test2(ref int m)
        {
            m = m - 300;
        }

        //out参数
        static void M1(out int m)
        {  //1、在方法执行完毕之前必须对out参数赋值。
           //2、out参数无法获取变量传递进来的值，只能对传递进来的变量进行赋值。
           //3、out参数在使用之前必须在方法内部对其进行赋值。
            m = 200;
        }
        //out 参数应用于多个返回值的场景
        static int M2(out int a, out int b)
        {
            a = 30;
            b = 20;
            return a+b;
        }
    }
}
