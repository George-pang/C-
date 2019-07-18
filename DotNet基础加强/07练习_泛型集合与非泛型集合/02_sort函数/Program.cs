using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_sort函数
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList(new int[] { 10, 42, 26, 68, 59, 88 });
            //ArrayList Sort函数默认升序排序
            arr1.Sort();
            //没有降序排序，但有反转函数（先升再反转）
            arr1.Reverse();
            for (int i = 0; i < arr1.Count; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.ReadKey();
            Console.WriteLine();

            ArrayList arr2 = new ArrayList(new string[] {"cr","plq","dh","lyj","xy"});
            arr2.Sort();
            for (int i = 0; i < arr2.Count; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.ReadKey();

            Console.WriteLine();

            ArrayList arr3 = new ArrayList();
            Person p1 = new Person();
            p1.name = "cr";
            p1.age = 20;
            p1.gender = "男";

            Person p2 = new Person();
            p2.name = "ltj";
            p2.age = 19;
            p2.gender = "男";

            Person p3 = new Person();
            p3.name = "dh";
            p3.age = 21;
            p3.gender = "女";

            Person p4 = new Person();
            p4.name = "lyj";
            p4.age = 22;
            p4.gender = "女";
            arr3.Add(p1);
            arr3.Add(p2);
            arr3.Add(p3);
            arr3.Add(p4);
            arr3.Sort();
            for (int i = 0; i < arr3.Count; i++)
            {
                Console.WriteLine(((Person)arr3[i]).name);
            }
            Console.ReadKey();
        }
    }

    public class Person:IComparable  //要想实现ArrayList的Sort函数,其存储的类必须实现IComparable接口
    { 
        public string name { get; set; }
        public int age { get; set; }
        public string gender {get;set;}

        public int CompareTo(object obj) //具体实现接口中的CompareTo()方法
        {
            Person p = obj as Person;
            if (p != null)
            {
                return this.age - p.age;
            }
            else {
                return 0;
            }
        }

        //int IComparable.CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
