using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_判断两个对象是否是同一个对象
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 类型比较
            Person p1 = new Person();
            p1.name = "张三";
            p1.age = 18;
            p1.gender = "男";

            Person p2 = new Person();
            p2.name = "张三";
            p2.age = 18;
            p2.gender = "男";

            Person p3 = p1;

            //使用Object.ReferenceEquals()方法来比较两个对象是否是同一个对象（在堆内存上是同一个对象、指向同一个地址）
            Console.WriteLine("使用Object.ReferenceEquals()方法来比较两个对象是否是同一个对象");
            //返回true或false
            Console.WriteLine(Object.ReferenceEquals(p1, p2));
            Console.WriteLine(Object.ReferenceEquals(p1, p3));
            int a = 3, b = 3;
            Console.WriteLine(Object.ReferenceEquals(a,b));
            Console.WriteLine("Object.ReferenceEquals()对于两个值类型，永远返回false");
            Console.WriteLine();


            Console.WriteLine("使用==来判断");
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1==p3);
            Console.WriteLine();

            Console.WriteLine("使用Object.Equals()来判断");
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

            Console.ReadKey();
            #endregion

            #region string比较
            //对于字符串类型来说，Equals方法被重载，这个重载的方法中其实是判断两个字符串中的字符是否完全一样，如果一样就返回true，
            //并不是判断两个变量是否是同一对象。
            //并且字符串类也重写了Object类中的Equals方法，该方法中也是判断两个字符串中的字符是否一样，如果一样就返回true，
            //并不是判断两个变量是否是同一对象。
            //在字符串类中，有一个操作符重载，对==这个操作符进行了重载，在该重载函数中也是对字符串的内容进行了比较，
            //所以==表现出了与Equals相同的效果。

            Console.WriteLine();
            //下面的s1和s2是两个不同的对象，因为new了两次，在堆内存中确实存在两块不同的内存。
            string s1 = new string(new char[] { 'a', 'b', 'c' });
            string s2 = new string(new char[] { 'a', 'b', 'c' });

            ////下面的s1和s2确实是一个对象，三种方法都返回true
            //string s1 = "abc";
            //string s2 = "abc";
            Console.WriteLine(s1==s2); //两个字符串的==判断，实际上内部就是调用了 Equals函数
            Console.WriteLine(s1.Equals(s2)); //两个字符串的Equals是判断的是字符串内容是否相等。
            Console.WriteLine(Object.ReferenceEquals(s1,s2));

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
