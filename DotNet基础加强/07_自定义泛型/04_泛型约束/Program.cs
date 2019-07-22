using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_泛型约束
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1<int, Stream, int, FileStream, Person> mc = new Class1<int, Stream, int, FileStream, Person>();
            mc[0] = 3000;
            mc[1] = 4000;
            Console.WriteLine(mc[0]);
            Console.WriteLine(mc[1]);
            Console.WriteLine();
            Console.ReadKey();


        }
    }

    //自定义泛型类
    //使用泛型可以是"算法重用"，只是数据类型发生了变化 
    public class Class1<T,K,V,M,N>
        where T:struct //约束T必须是值类型
        where K:class  //约束K必须是引用类型
        where V:IComparable //约束V必须是实现了某个接口的类型
        where M:K //约束M必须是K类型或K类型的子类型
        where N:class,new() //约束N必须是引用类型，并且具有一个无参的构造函数
        //对一个类型有多个约束时用“逗号”隔开，多个约束与new()一起使用时，new()写在最后
    {
        public T[] _arr = new T[5];

        //索引器
        public T this[int index]
        {
            get
            {
                return _arr[index];
            }
            set
            {
                _arr[index] = value;
            }
        }

    }

    public class Person
    {
        public string name{get;set;}
        public int age{get;set;}
    }
}
