using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_foreach循环3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            foreach (var item in p) //这里的遍历集合不用自定义类.方法名，但定义类中的方法名必须为GetEnumerator
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        private string[] names = new string[] { "陈瑞", "丁海", "庞陆强", "林陶钧", "路永进", "寻瑶" };

        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        //定义GetEnumerator方法，yield返回个IEnumerator类型，可实现自定义Person类的foreach遍历
        //方法名为GetEnumerator
        public IEnumerator GetEnumerator()
        { 
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }

}
