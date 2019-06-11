using CalcutlatorDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string yunSuanFu = Console.ReadLine();
            Console.WriteLine("请输入第二个数字：");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Calculator calculator = GetComputedObject(yunSuanFu, n1, n2);
            Console.WriteLine("计算结果为：{0}", calculator.JiSuan());  //调用JiSuan方法，实际操作结果根据不同对象来处理---利用抽象类实现的多态

            Console.ReadKey();


        }

        //简单工厂设计模式
        private static Calculator GetComputedObject(string yunSuanFu, double n1, double n2)
        {
            Calculator result = null;
            switch (yunSuanFu)
            {
                case "+":
                    result = new JiaFaClass(n1, n2);
                    break;
                case "-":
                    result = new JianFaClass(n1, n2);
                    break;
                case "*":
                    result = new ChengFaClass(n1, n2);
                    break;
                case "/":
                    result = new ChuFaClass(n1, n2);
                    break;
            }
            return result;

        }
    }
}
