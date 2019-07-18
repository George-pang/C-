using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_sort函数比较器
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //arr3.Sort();//直接调用Sort方法，是采用实现IComparable接口的类型中默认的方式进行排序
            arr3.Sort(new PersonSortByNameLengthAsc());
            for (int i = 0; i < arr3.Count; i++)
            {
                Console.WriteLine(((Person)arr3[i]).name);
            }
            Console.ReadKey();
        }
    }
    public class Person : IComparable  //要想实现ArrayList的Sort函数,其存储的类必须实现IComparable接口
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public int CompareTo(object obj) //具体实现接口中的CompareTo()方法
        {
            Person p = obj as Person;
            if (p != null)
            {
                return this.age - p.age;
            }
            else
            {
                return 0;
            }
        }
    }
    //比较器---通过定义多个比较器来实现ArrayList自定义排序，而不是修改ArrayList中的类型定义代码
    public class PersonSortByNameLengthAsc : IComparer
    { 
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 != null && p2 != null)
            {
                return p1.name.Length - p2.name.Length;
            }
            else 
            {
                throw new Exception("null不能进行比较");
            
            }
        }
    }
}
