using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_主动抛出异常
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("请输入你的姓名:");
            //    string name = Console.ReadLine();
            //    if (name == "张三")
            //    {
            //        throw new Exception("姓名不合法！！！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("姓名合法：{0}", name);
            //    }
            //}

            while (true)
            {
                Console.WriteLine("请输入你的姓名:");
                string name = Console.ReadLine();
                try
                {
                    if (name == "张三")
                    {
                        throw new Exception("姓名不合法！！！"); //主动触发异常---参数：string message
                    }
                    else
                    {
                        Console.WriteLine("姓名合法：{0}", name);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("引发异常了！");
                    Console.WriteLine(ex.Message);//异常信息
                    Console.WriteLine(ex.Source); //异常来源---命名空间名
                    Console.WriteLine(ex.StackTrace);//触发异常的代码位置
                }

            }


            //Console.ReadKey();
        }
    }
}
