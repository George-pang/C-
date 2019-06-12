using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2, 3);
            Test2("测试", 1, 2, 3);

            Test(new int[]{4,5,6});//可变参数在方法使用时可以直接传递个数组进来

            Console.ReadKey();
        }
        //1、可变参数---使用params关键字，跟一个数组
        static void Test(params int[] x)
        {
            if (x != null) {  //可变参数可以不传（则数组长度为0）,也可以传null
                for (int i = 0; i < x.Length; i++)
                {
                    Console.WriteLine(x[i]);
                }
            }
        }

        //2、当有多个参数时，可变参数必须作为最后一个参数
        //3、可变参数在方法使用时可传可不传，当没有传参数时，可变参数是一个长度为0的数组
        //4、可变参数在方法使用时也可直接传递一个数组进来。
        //5、可变参数在方法使用时可以直接传个null进来。
        static void Test2(string msg, params int[] x)
        { 
        
        }
    }
}
