using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_按引用传递ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 100;
            //“按引用传递”传递的是栈本身的地址
            //“值传递”传递的是栈的内容,是将栈中的内容拷贝了一个副本
            //“按引用传递”时形参和实参实际上就是栈上一个变量的两个不同别名而已
            M1(ref m); //按引用类型传递(ref关键字，定义和调用时都要)时,形参和实参共用一个栈的地址，在栈上实际上是一个变量
            Console.WriteLine(m); //101

            Person p1 = new Person();
            p1.name = "张三";
            M2(ref p1);
            Console.WriteLine(p1.name);//李四

            Console.ReadKey();
            
        }
        static void M1(ref int n)
        {
            n = n + 1;
        }
        static void M2(ref Person p)
        {
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
