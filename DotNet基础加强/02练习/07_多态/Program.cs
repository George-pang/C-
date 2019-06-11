using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Object();
            Person p = new Person();
            string a = "Hello World!";
            Console.WriteLine(o.ToString()); //对象ToString---返回命名空间.类名
            Console.WriteLine(p.ToString()); //对象ToString---返回命名空间.类名
            Console.WriteLine(a.ToString()); //String 类重写了ToString方法，返回当前字符串


            //类型转换的第一种方式：（类名）实例对象名
            Person p1 = new Student();
            //Person p1 = new Person();
            if (p1 is Student) {  //用is判断对象是否是某个类的实例
                Student stu1 = (Student)p1;            
            }
            Console.WriteLine("OK");

            //类型转换的第二种方式：as---转换失败会返回null，而不会报异常

            Person p2 = new Person();
            Student stu2 = p2 as Student;
            if (stu2 != null)
            {
                Console.WriteLine("转换成功！");
            }
            else {
                Console.WriteLine("转换失败！");
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

    public class Student:Person
    {
        public string classId { get; set; }
    }
}
