using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayList集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 两个集合{"a","b","c","d","e"}和{"d","e","f","g","h"}，去除重复值合并成一个

            ArrayList arr1 = new ArrayList(new string[] { "a", "b", "c", "d", "e" });
            ArrayList arr2 = new ArrayList(new string[] { "d", "e", "f", "g", "h" });
            for (int i = 0; i < arr2.Count; i++)
            {
                if (!arr1.Contains(arr2[i])) {
                    arr1.Add(arr2[i]);
                }
            }
            Console.WriteLine("合并后的集合元素个数为{0}",arr1.Count);
            for (int i = 0; i < arr1.Count; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
            Console.WriteLine();

            #endregion

            #region 随机生成10个1~100间的整数放入ArrayList中，要求这10个数是偶数且不能重复

            ArrayList intArr = new ArrayList();
            Random rd = new Random();
            //Random rd2 = new Random(8);//使用指定的种子生成Random类的新实例（此时生成的是同一串随机数）
            while (intArr.Count < 10) {  //循环条件
                int num = rd.Next(1, 101);//随机生成1~101(不包括101)的随机整数
                if (num % 2 == 0 && !intArr.Contains(num)) 
                {
                    intArr.Add(num);
                }
            }
            Console.WriteLine("ArrayList的长度为：{0}",intArr.Count);
            for (int i = 0; i < intArr.Count; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            Console.ReadKey();

            #endregion

            #region 有一个空格分隔的整数字符串，将其重新排序，奇数显示在左侧，偶数显示在右侧
            Console.WriteLine();
            string str = "2 7 8 3 22 9 5 11";
            string[] arr = str.Split(new char[]{' '});
            ArrayList arrOdd = new ArrayList();
            ArrayList arrEven = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.Parse(arr[i]) % 2 == 0)
                {
                    arrEven.Add(arr[i]);
                }
                else 
                {
                    arrOdd.Add(arr[i]);
                }
                
            }
            for (int i = 0; i < arrEven.Count; i++)
            {
                arrOdd.Add(arrEven[i]);
                
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrOdd.Count; i++)
            {
                sb.Append(arrOdd[i]+" ");
            }
            Console.WriteLine(sb);
            Console.ReadKey();

            #endregion
        }
    }
}
