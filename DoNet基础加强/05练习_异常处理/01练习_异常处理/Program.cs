using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01练习_异常处理 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Person zs = new Person();
            zs = null;//对变量zs重新赋值，指向空对象指针
            try  //可能会出现异常的代码
            {
                zs.name = "张三"; //这句会出现异常
                //try块中 出现异常所在行 后面的代码不会再执行
                Console.WriteLine(zs.name);
                Console.WriteLine("============================");
            }
            catch (Exception ex) //出现异常时执行的代码---针对不同的异常可以有多个catch块
            {
                Console.WriteLine(ex.Message); //Exception实例对象的Message属性包含了异常信息
            }
            finally //无论是否出现异常，都会执行finally块下的代码---一般用作代码清理、资源释放
            {
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }


            Console.ReadKey();
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
