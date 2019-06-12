using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ref与out参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //交换2个int变量的值---不能使用out参数（因为out参数无法接收传递进来的变量值）
            int a = 30;
            int b = 60;
            ChangeVar(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            //模拟登陆---返回bool和string
            while (true)
            {
                Console.WriteLine("请输入用户名：");
                string uid = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string pwd = Console.ReadLine();
                string msg;
                bool result = LoginJudge(uid, pwd, out msg);
                if (result)
                {
                    Console.WriteLine("登陆成功！提示：{0}", msg);
                }
                else
                {
                    Console.WriteLine("登陆失败！提示：{0}", msg);
                } 
            }

            //Console.ReadKey();

        }

        static void ChangeVar(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        //模拟登陆
        static bool LoginJudge(string uid, string pwd, out string msg)
        {
            bool result = false;
            if (uid != "admin")
            {
                msg = "用户名错误！";
            }
            else if (pwd != "888888")
            {
                msg = "密码错误！";
            }
            else
            {
                msg = "登陆成功！";
                result = true;
            }
            return result;
        }
    }
}
