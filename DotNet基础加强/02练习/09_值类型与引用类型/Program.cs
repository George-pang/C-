using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 值类型与引用类型
            //1、值类型赋值---值类型赋值时是将栈中的数据拷贝了一个副本
            int m = 100;
            int n = m;
            n = n + 1;
            Console.WriteLine(n);

            //2、引用类型赋值---引用类型赋值时是将栈中存放的堆中实际数据的地址拷贝了一个副本
            Person p = new Person();
            p.name = "张三";
            Person p1 = p;//因为引用类型传递的是地址,p和p1执行堆中的同一个内存空间，所以p1.name改变了，p.name也改变啦
            p1.name = "李四";
            Console.WriteLine(p.name);
            #endregion

            #region 案例 值类型与引用类型参数 作为“值传递”的情况
            Person hl = new Person();
            hl.name = "黄林";
            M2(hl); //作为“值传递”时，实参和形参是两个不同的变量，函数调用时是将实参赋给形参变量

            Console.WriteLine(hl.name); //臧三
            #endregion

            Console.ReadKey();
        }

        public static void M2(Person p)
        {
            p.name = "臧三";
            p = new Person();
            p.name = "李四";
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
