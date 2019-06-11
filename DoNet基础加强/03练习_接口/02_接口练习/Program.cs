using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable bird = new Sparrow();
            bird.Fly();
            IFlyable bird2 = new Parrot();
            bird2.Fly();

            ICollectHomeWork student = new Student();
            ICollectHomeWork teacher = new Teacher();
            student.CollectHomeWork();
            teacher.CollectHomeWork();

            Console.ReadKey();
        }
    }

    //父类--鸟
    public class Bird
    {
        public void Bark()
        {
            Console.WriteLine("春暖花开,鸟儿丛中叫！");
        }
    }
    //接口---飞
    public interface IFlyable
    {
        void Fly(); //接口内方法不能有实现
    }

    //麻雀
    public class Sparrow : Bird,IFlyable
    { 
        public void Fly()
        {
            Console.WriteLine("麻雀天上飞。。。");
        }
    }
    //鸵鸟    
    public class Ostrich : Bird
    {
 
    }
    //企鹅
    public class Penguin : Bird
    { 
    }
    //鹦鹉
    public class Parrot : Bird,IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉家中飞。。。");
        }
    }
}
