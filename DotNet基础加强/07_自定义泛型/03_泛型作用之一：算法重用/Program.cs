using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_泛型作用之一_算法重用
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<string> mc = new Class1<string>();
            mc[0] = "黄林";
            mc[1] = "陈瑞";
            Console.WriteLine(mc[0]);
            Console.WriteLine(mc[1]);
            Console.WriteLine();
            Console.ReadKey();

            Class1<int> mc2 = new Class1<int>();
            mc2[0] = 4;
            mc2[1] = 8;
            Console.WriteLine(mc2[0]);
            Console.WriteLine(mc2[1]);
            Console.WriteLine();
            Console.ReadKey();

        }
    }

    //使用泛型可以是"算法重用"，只是数据类型发生了变化 
    public class Class1<T>
    { 
        public T[] _arr=new T[5];

        //索引器
        public T this[int index]
        {
            get {
                return _arr[index];
            }
            set {
                _arr[index] = value;
            }
        }

    }
}
