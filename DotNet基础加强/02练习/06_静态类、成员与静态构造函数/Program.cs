using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_静态类_成员与静态构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(); //使用了实例类MyClass,先初始化静态成员，因此执行了静态构造函数---先打印"静态构造函数被执行了！"
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
            MyClass.age = 18; //类的静态成员直接通过类.成员名来调用。
            Console.WriteLine(MyClass.age);
            Console.ReadKey();
        }

        public static class Person //静态类中所有成员都是静态的
        {
            //static int age;//类中的静态成员，在第一次使用静态类的时候初始化
        }

        public class People
        {
            public string name { get; set; } //自动属性
            public int age { get; set; }
            //当实例类中出现了静态成员并赋初始值时，除了默认有一个无参的实例构造函数外，
            //还有一个默认的无参静态构造函数（在静态构造函数中赋初始值）
            public static string planet="地球";
        }

        public class MyClass
        {
            public static int age{get;set;} //静态成员多用于共享的数据或辅助工具类
            public static string name { get; set; } //在类被创建时要先初始化静态成员

            //静态构造函数
            /* 特点：静态构造函数是由系统调用的，所以不允许添加访问修饰符，默认就是private。
             * 静态构造函数是在第一次使用静态类、或静态成员之前自动调用的，无法控制传参，所以也不能添加任何参数。
             * 1、静态构造函数只执行一次。
             * 2、静态构造函数在第一次使用静态类或静态成员之前自动调用。
             */
            static MyClass() 
            {
                Console.WriteLine("静态构造函数被执行了！");  //静态构造函数在第一次使用静态类或静态成员前执行，只执行一次
                age = 18;
                name = "黄林";
            }

            //实例构造函数
            public MyClass() 
            {
                Console.WriteLine("实例构造函数被执行了！"); //在实例化对象时执行，会执行多次
            }
        }
    }
}
