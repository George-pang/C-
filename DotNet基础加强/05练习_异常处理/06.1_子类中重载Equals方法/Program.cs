using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1_子类中重载Equals方法
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

            Console.WriteLine(p1.Equals(p2)); //调用Person类中重写的Equals方法
            Console.WriteLine(Object.ReferenceEquals(p1,p2));

            Console.ReadKey();

        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public override bool Equals(object obj) //重载继承Object类的Equals(object obj)方法---比较两个对象的属性而不是判断是否是同一对象
        {
            Person p = obj as Person;
            if (p == null)
            {
                return false;
            }
            if (this.name == p.name && this.age == p.age && this.gender == p.gender)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

    }
}
