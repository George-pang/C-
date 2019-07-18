using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_非泛型集合ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 非泛型集合ArrayList

            //创建一个ArrayList集合，集合都是使用.Count获取元素个数，而数组是使用.Length获取元素的个数
            ArrayList arr = new ArrayList();

            //向集合中添加元素
            Console.WriteLine("向集合中添加元素");
            //向集合中添加单个元素
            arr.Add(999);
            arr.Add("骚瑞");
            arr.Add(true);
            arr.Add(new string(new char[] {'黄','林'}));
            Person p1 = new Person();
            p1.name = "骚瑞";
            p1.age = 18;
            p1.gender = "男";
            arr.Add(p1); //add()方法形参为Object类，所以可传任何类型作为实参
            Console.WriteLine("当前集合中元素的个数为：{0}", arr.Count);
            Console.WriteLine("当前集合的容量为：{0}", arr.Capacity); 
            //向集合中添加多个元素--AddRange() 实参可传所有集合和数组（都是Icollection接口的子类）
            arr.AddRange(new int[] { 1, 3, 5, 7, 8, 10, 12 });

            //获取集合中元素的个数
            Console.WriteLine("当前集合中元素的个数为：{0}",arr.Count);
            //获取当前集合的容量
            Console.WriteLine("当前集合的容量为：{0}", arr.Capacity);
            
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();

            Console.WriteLine("移除集合中的元素");
            //清空集合元素
            Console.WriteLine("清空集合元素");
            //for (int i = 0; i < arr.Count; i++) //这种方式无法完全清空集合，因为.Count是随之变化的
            //{
            //    arr.RemoveAt(i); //RemoveAt()通过索引来移除元素
            //}
            //Console.WriteLine(arr.Count);
            arr.Clear();//清空集合
            Console.WriteLine(arr.Count);
            Console.WriteLine();

            ArrayList arr1 = new ArrayList();
            string s1="黄林";
            arr1.Add(s1);
            arr1.Add(999);
            arr1.Add(p1);
            arr1.Add(true);
            Person p2 = new Person();
            p2.name = "张三";
            p2.age = 19;
            p2.gender = "女";
            arr1.Add(p2);
            arr1.AddRange(new int[] {1,2,3,4,5});
            Person p3 = new Person();
            p3 = p2;
            Console.WriteLine("使用Remove()来移除");
            arr1.Remove(999);
            arr1.Remove(new string(new char[] { '黄', '林' })); //Remove移除对象内部实际调用的是类似Equals，在string类时，实际比的是string的内容是否相同
            arr1.Remove(p3);
            Console.WriteLine("使用RemoveRange()来移除多个元素");
            arr1.RemoveRange(3,3);
            Console.WriteLine(arr1.Count);
            for (int i = 0; i < arr1.Count; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            //判断集合是否包含某个元素---实际上内部调用的也是类似Equals
            Console.WriteLine("判断集合是否包含某个元素---实际上内部调用的也是类似Equals");
            Console.WriteLine(arr1.Contains(p3));
            Console.WriteLine(arr1.Contains(p1));


            //将集合转换为Object类型数组
            Console.WriteLine();
            Console.WriteLine("将集合转换为Object类型数组");
            Console.WriteLine(arr1.ToArray());

            Console.ReadKey();



            #endregion
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
