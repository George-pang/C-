using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_字符串特性_字符串池
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串池只针对字符串常量而言
            string s1 = "abc"; 
            string s2 = "abc";
            Console.WriteLine(Object.ReferenceEquals(s1,s2)); //由于字符串的不可变性和字符串池，上面的s1和s2是同一个对象

            string s3 = "abc";
            string a = "a";
            string b = "b";
            string c = "c";
            string s4 = a + b + c;
            Console.WriteLine(Object.ReferenceEquals(s3,s4));//false---s3和s4不是同一对象---因为字符串池只针对字符串常量

            string s5 = "abc";
            string s6 = "a" + "b" + "c";
            Console.WriteLine(Object.ReferenceEquals(s5,s6));//true---s5和s6是同一对象



            Console.ReadKey();
        }
    }
}
