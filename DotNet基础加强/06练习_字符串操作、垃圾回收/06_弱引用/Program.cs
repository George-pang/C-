using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_弱引用
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "骚瑞";
            WeakReference wr = new WeakReference(p);//创建弱引用实例对象，将p引用的Person对象添加到wr对象的引用
            p = null;//过一段时间，p对象就会被垃圾回收

            Console.WriteLine("========================");
            Console.WriteLine("========================");
            Console.WriteLine("========================");

            ////通过弱引用，重新使用原来的Peron对象
            //if (wr.IsAlive) 
            //{
            //    object o = wr.Target;
            //    if (wr.Target != null)
            //    {
            //        Person p1 = o as Person; //重新使用Person对象（还是原来的对象）
            //    }
            //}


            //通过弱引用，重新使用原来的Peron对象
            object o = wr.Target; //获取当前WeakReference对象引用的对象
            if (wr.Target != null)
            {
                Person p1 = o as Person; //重新使用Person对象（还是原来的对象）
            }

        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
