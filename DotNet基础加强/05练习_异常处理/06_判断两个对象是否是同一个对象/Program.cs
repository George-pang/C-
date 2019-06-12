using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_判断两个对象是否是同一个对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.name = "张三";
            p1.age = 18;
            p1.gender = "男";

            Person p2 = new Person();
            p2.name = "张三";
            p2.age = 18;
            p2.gender = "男";

            Person p3 = p1;

            //使用Object.ReferenceEquals()方法来比较两个对象是否是同一个对象（在堆内存上是同一个对象）
            Console.WriteLine("使用Object.ReferenceEquals()方法来比较两个对象是否是同一个对象");
            //返回true或false
            Console.WriteLine(Object.ReferenceEquals(p1, p2));
            Console.WriteLine(Object.ReferenceEquals(p1, p3));
            int a = 3, b = 3;
            Console.WriteLine(Object.ReferenceEquals(a,b));
            Console.WriteLine("Object.ReferenceEquals()对于两个值类型，永远返回false");
            Console.WriteLine();


            Console.WriteLine("使用==来判断");
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1==p3);
            Console.WriteLine();

            Console.WriteLine("使用Object.Equals()来判断");
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

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
