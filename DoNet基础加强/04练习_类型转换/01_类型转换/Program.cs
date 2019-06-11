using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            double m = n; //隐式类型转换
            int a = (int)m;//显式类型转换
            Console.WriteLine(m);
            Console.WriteLine(a);
            Console.WriteLine();

            Student stu = new Student();
            Person per = stu; //子类赋给父类变量时会发生隐式类型转换
            //Person per2 = new Person();
            Person per2 = new Student();
            Student stu2 = (Student)per2; //父类赋给子类需要显式（直接）类型转换---前提父类是由子类隐式转换过来的
            Console.WriteLine(per);
            Console.WriteLine(stu2);
            Console.WriteLine();

            //将字符串转换为数值类型（int、float、double）---Parse()转换失败报异常，TryParse()转换失败不报异常
            Console.WriteLine("将字符串转换为数值类型（int、float、double）---Parse()转换失败报异常，TryParse()转换失败不报异常");
            string str = "123";
            Console.WriteLine(int.Parse(str));
            Console.WriteLine(double.Parse(str));
            Console.WriteLine(float.Parse(str));
            string str_1 = "a1234";

            int result = 0;
            if (int.TryParse(str_1, out result)) //TryParse的用法
            {
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine("int.TryParse转换失败！");
            }
            Console.WriteLine();

            //将任何类型转换为字符串 ToString();
            Console.WriteLine("将任何类型转换为字符串 ToString()");
            int mm = 24;
            Person p = new Person();
            Console.WriteLine(mm.ToString());
            Console.WriteLine(p.ToString());
            Console.WriteLine();

            //sizeof()获取各个类型的字节大小
            Console.WriteLine("sizeof()获取各个类型的字节大小");
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(short));
            Console.WriteLine(sizeof(long));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine();

            //as与直接类型转换--as转换失败返回null
            Console.WriteLine("as与直接类型转换--as转换失败返回null");
            Person per3 = new Person();
            Student stu3 = new Student();
            if (per3 is Student) //判断对象是否是某一个类型或父类型，返回true和false。另外is操作符永远不会抛出异常
            {
                Console.WriteLine((Student)per3);
            }
            else
            {
                Console.WriteLine("转换失败！");
            }
            Console.WriteLine(per3 as Student);//as转换类型失败则返回null
            Console.WriteLine();


            //Convert类型转换---考虑数据意义的转换---将Object类型转换为其他类型
            Console.WriteLine("Convert类型转换---考虑数据意义的转换");
            string str4 = "123";
            Console.WriteLine(Convert.ToInt32(str4));
            //Console.WriteLine(Convert.ToInt32(new Student())); //转换失败会报异常
            Console.WriteLine();

            //GetType()获取类型
            Console.WriteLine("GetType()获取类型");
            Student stu5 = new Student();
            Console.WriteLine(stu5.GetType()); //获取变量所属类型
            Console.WriteLine(stu5.GetType().BaseType); //获取变量所属类型的父类型
            Console.WriteLine(stu5.GetType().BaseType.BaseType);

            Console.ReadKey();
        }

    }
    public class Person
    {
        public string name { get; set; }
        private int _age;
        public int age
        {
            get { return _age;}
            set { _age = value; }
        }
    }
    public class Student : Person
    { 
    }
}
