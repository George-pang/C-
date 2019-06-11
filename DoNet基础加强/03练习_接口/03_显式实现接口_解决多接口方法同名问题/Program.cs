using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_显式实现接口_解决多接口方法同名问题
{
    class Program
    {
        static void Main(string[] args)
        {
            IFace2 stu = new Student();
            stu.Fly();

            //Teacher te = new Teacher();
            //te.Fly(); //报错---显式实现接口不能通过类对象变量来调用接口方法

            IFace1 te = new Teacher(); //显式实现接口是通过接口变量来调用接口方法的
            te.Fly();
            IFace2 t2 = new Teacher();
            t2.Fly();

            Console.ReadKey();
        }

        //父接口1
        public interface IFace1
        {
            void Fly(); //不能加访问修饰符，默认是public
        }
        //父接口2
        public interface IFace2
        {
            void Fly();
        }
        //Student类，实现IFace1，IFace2接口
        public class Student : IFace1, IFace2
        {
            public void Fly()
            {
                Console.WriteLine("Fly...");
            }
        }
        //Teacher类，实现IFace1，IFace2接口
        public class Teacher : IFace1, IFace2
        {
            //显式实现接口，不能有访问修饰符，默认是private
            //显式实现接口，只能通过接口来调用接口方法，不能通过类对象本身来调用（因为是private）
            void IFace1.Fly()
            {
                Console.WriteLine("这是接口1中的Fly");
            }

            void IFace2.Fly()
            {
                Console.WriteLine("这是接口2中的Fly");
            }
        }
    }
}
