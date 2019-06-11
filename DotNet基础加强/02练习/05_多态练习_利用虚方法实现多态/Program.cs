using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_多态练习_利用虚方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Manager();//子类可以赋给父类，但父类不可以赋给子类
            //employee1.ClockIn();

            Employee[] emps = new Employee[5];
            emps[0] = new Employee();
            emps[1] = new Manager();
            emps[2] = new Manager();
            emps[3] = new Employee();
            emps[4] = new Manager();

            for (int i = 0; i < emps.Length; i++) 
            {
                emps[i].ClockIn();
            }

            Console.ReadKey();
        }
    }
    public class Employee
    { 
        public virtual void ClockIn(){  
            Console.WriteLine("员工上班打卡！");
            //Console.ReadKey();
        }    
    }

    public class Manager:Employee
    {
        public override void ClockIn()  //override关键字重写父类虚方法---只改变方法体，不改变其他
        {
            Console.WriteLine("经理上班打卡！");
            //Console.ReadKey();     
        }
    }
}
