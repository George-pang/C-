using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_字符串特性_不可变性
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串不可变性1
            //字符串不可变性----字符串一旦创建，在堆内存中的内容是不可改变的。
            string s1 = "Hello World!";
            string x = s1.ToUpper(); //字符串的不可变性，并没有改变原来的字符串，而是返回了一个副本
            Console.WriteLine(s1); //"Hello World!"---字符串的不可变性，重新生成了副本
            Console.WriteLine(x);


            Console.WriteLine();
            string str1 = "abc";
            string str2 = "x";
            str1 = str1 + str2;
            Console.WriteLine(str1); //"abcx"---并没有改变堆内存中的字符串内容，而是开辟了新的堆内存存放拼接后的内容，并将堆内存地址赋给了变量str1.


            Console.ReadKey();
            #endregion

            #region 字符串不可变性2
            Console.WriteLine();
            string a = "a";
            string b = "b";
            string c = "c";
            a = a + b;
            a = a + c;
            Console.WriteLine(a);

            Console.ReadKey();
            #endregion


        }
    }
}
