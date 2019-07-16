using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            List<int> list2 = new List<int>();
            list2.Add(999);
            list2.Add(222);
            Console.WriteLine(list2.Capacity);
            Console.WriteLine(list2.Count);
            Console.WriteLine(list2[1]);

            Console.WriteLine();
            Console.WriteLine("Dictionary泛型集合，声明键值类型");
            Dictionary<string, int> dict = new Dictionary<string, int>();//声明键类型、值类型
            dict.Add("cr", 99);
            dict.Add("ltj", 88);
            dict.Add("lyj", 66);
            Console.WriteLine("Dictionary泛型集合的遍历：");
            Console.WriteLine("遍历键");
            foreach (string item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("遍历值");
            foreach (int item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("直接遍历键值对");
            foreach (KeyValuePair<string,int> item in dict) //注意循环变量的写法
            {
                Console.WriteLine("键:{0}→值:{1}",item.Key,item.Value);
                
            }

            Console.ReadKey();
        }
    }
}
