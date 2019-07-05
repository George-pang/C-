using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_hashtable集合演示
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable(); //Hashtable集合
            hash.Add("cr", "陈瑞");
            //hash.Add("cr", "陈睿");//Hashtable中的键唯一，一定不能重复
            hash.Add("ltj", new Person { name = "林陶钧", age = 18, gender = "男" });
            Console.WriteLine(hash["cr"].ToString());
            //判断Hashtable集合中是否包含某个键
            Console.WriteLine(hash.ContainsKey("cr"));
            //判断Hashtable集合中是否包含某个值
            Console.WriteLine(hash.ContainsValue("陈瑞"));
            Console.WriteLine(hash.Count);//集合的长度
            Console.WriteLine();

            Console.WriteLine("遍历Hashtable");
            //Hashtable集合无法通过索引获取值，故使用foreach循环
            Console.WriteLine("遍历键");
            foreach (object item in hash.Keys)
            {
                Console.WriteLine("键：{0}→值：{1}",item,hash[item]);
            }
            Console.WriteLine("遍历值");
            foreach (object item in hash.Values)
            {
                Console.WriteLine("值为：{0}",item);
            }
            Console.WriteLine("遍历元素");
            foreach (DictionaryEntry item in hash) //循环变量使用DictionaryEntry类型
            {
                Console.WriteLine("键：{0}→值：{1}",item.Key,item.Value);
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
