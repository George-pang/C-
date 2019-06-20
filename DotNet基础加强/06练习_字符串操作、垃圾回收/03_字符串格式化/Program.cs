using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_字符串格式化
{
    class Program
    {
        static void Main(string[] args)
        {
            //说明——》          {索引[,宽度+对齐][:格式字符串]}
            string s = "我叫{0},我今天发了{1,-10:C2}工资";
            Console.WriteLine(s,"黄林","8888.8888"); //怎么没起效果
            //Console.WriteLine(string.Format(CultrueInfo.CreateSpecificCulture("en-cs"), s, "黄林", "8888.8888"));
            Console.WriteLine();

            //判断是否是空字符串
            Console.WriteLine("判断是否是空字符串");
            string s1 = "";
            Console.WriteLine(s1=="");
            Console.WriteLine(s1==string.Empty);
            Console.WriteLine(s1.Length==0); //推荐用这种方法
            Console.WriteLine();
            Console.WriteLine("判断是否是空对象");
            string s2 = null;
            Console.WriteLine(s2==null);
            Console.WriteLine("判断是否是空对象或空字符串");
            Console.WriteLine(s2==null||s1.Length==0);
            Console.WriteLine(string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s1)); //string.IsNullOrEmpty(s1)判断是否是空对象或空字符串
            Console.WriteLine();

            Console.WriteLine("将string转为char数组");
            string s3 = "abcd";
            char[] c1 = s3.ToCharArray(); //char 数组
            Console.WriteLine(c1);
            Console.WriteLine("char数组转为string,使用string类构造函数构建string",new string(c1));
            Console.WriteLine();

            Console.WriteLine("string大小写转换");
            string s4 = "abcd";
            string s5 = "ABCD";
            Console.WriteLine(s4==s5);
            Console.WriteLine(s4.Equals(s5));
            Console.WriteLine(s4.ToLower()==s5.ToLower());
            Console.WriteLine(s4.ToUpper()==s5.ToUpper());
            Console.WriteLine(s4.Equals(s5,StringComparison.CurrentCultureIgnoreCase)); //使用objec.Equals方法比较两字符串，忽略大小写
            Console.WriteLine();

            Console.WriteLine("获取string中指定string的索引");
            string s6 = "今天我吃了5个包子，6个烧麦，1杯豆浆！";
            Console.WriteLine(s6.IndexOf("烧麦"));
            Console.WriteLine(s6.IndexOf("油条"));//没有找到则返回-1
            Console.WriteLine("string截取");
            Console.WriteLine(s6.Substring(12,2));


            Console.ReadKey();
        }
    }
}
