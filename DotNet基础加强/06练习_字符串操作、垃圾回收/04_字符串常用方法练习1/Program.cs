using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_字符串常用方法练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 格式化"123---45-6--7-89",得到"123-45-6-7-89"
            Console.WriteLine("格式化123---45-6--7-89,得到123-45-6-7-89");
            string s1 = "123---45-6--7-89";
            string[] a1 = s1.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries); //参数2：移除分割后数组中的空字符串元素
            s1 = string.Join("-",a1);
            Console.WriteLine(s1);
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 从文件路径提取出文件名
            Console.WriteLine("从文件路径提取出文件名");
            string s2 = @"C:\a\b.txt"; //@符号---忽略字符串中的转移符
            Console.WriteLine(s2.Substring(s2.LastIndexOf("\\")+1));
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 格式化"192.168.10.5[port=80,type=ftp]"
            Console.WriteLine("格式化192.168.10.5[port=80,type=ftp]");
            string s3 = "192.168.10.5[port=80,type=ftp]";
            string[] a3 = s3.Split(new string[] { "[port=", ",type=", "]" },StringSplitOptions.RemoveEmptyEntries);
            string ip = a3[0];
            string port = a3[1];
            string type = a3.Length > 2 ? a3[2] : "http";
            Console.WriteLine("IP地址为{0}的服务器的{1}端口提供的服务为{2}",ip,port,type);
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 求员工工资文件中，员工的最高工资，最低工资和平均工资
            Console.WriteLine("求员工工资文件中，员工的最高工资，最低工资和平均工资");
            string[] lines = File.ReadAllLines("salary.txt", Encoding.Default);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
            //double minSalary = double.Parse(lines[0].Split(new string[] { "=" },StringSplitOptions.RemoveEmptyEntries)[1]);
            double MinSalary = double.Parse(lines[0].Split('=')[1]);
            double MaxSalary = double.Parse(lines[0].Split('=')[1]);
            double Sum = 0;
            int count1 = 0;
            foreach (var item in lines)
            {
                if (item.Length != 0) { //如果不为空行
                    count1++;
                    double num = double.Parse(item.Split('=')[1]);
                    if (num < MinSalary)
                    {
                        MinSalary = num;
                    }
                    if (num > MaxSalary)
                    {
                        MaxSalary = num;
                    }
                    Sum += num;
                }

            }
            Console.WriteLine("最低工资为：{0}，最高工资为：{1}，平均工资为{2}",MinSalary,MaxSalary,Sum/count1);
            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region 统计一段话中某个字符串出现的次数
            string s5 = "传智播客专注IT培训,Java培训,人工智能培训,Python培训,PHP培训,C++培训,大数据培训,UI设计培训,移动开发培训,网络营销培训,web前端培训,全栈工程师培训,产品经理...";
            int count = 0;
            int index=0;
            while(s5.IndexOf("培训",index)!=-1){
                count++;
                index = s5.IndexOf("培训", index) + "培训".Length;
            }
            Console.WriteLine(count);
            Console.ReadKey();
            #endregion
        }
    }
}
