using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_foreach使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("通过foreach来遍历数据，实际上是调用了一个'枚举器'来遍历数据，foreach只是一个语法上的简化，实际关系不大");
            Console.WriteLine("数组：");
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====================================");
            Console.WriteLine("ArrayList非泛型集合：");
            ArrayList arr2 = new ArrayList() { 33, 35, 36, 37, 38, 39, 40 };
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("List<>泛型集合：");
            List<int> list = new List<int>() { 11, 22, 33, 44, 55, 66 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("总结：凡是具有GetEnumerator（）方法的类型都可以使用foreach来遍历");
            Console.WriteLine("=====================================");
            Console.WriteLine("自定义Person类，没有实现了GetEnumerator（）方法，不能使用foreach遍历");
            Person per = new Person();
            for (int i = 0; i < per.count; i++)
            {
                Console.WriteLine(per[i]);
            }
            //foreach (var item in per)
            //{

            //}

            Console.ReadKey();

        }
    }

    public class Person
    {
        private string[] names = new string[] { "陈瑞", "丁海", "林陶钧", "路永进", "庞陆强", "寻瑶" };

        public int count { get { return names.Length; } }

        //创建只读索引器----可用于for循环
        public string this[int index]
        {
            get
            {
                return names[index];
            }
        }

        public string name { get; set; }
    }

}
