using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcutlatorDll   //添加项目 类库 生成的dll程序集文件---供项目 应用程序 生成的exe文件调用
{
    public abstract class Calculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        //抽象方法
        public abstract double JiSuan();

        //构造函数
        public Calculator(double n1, double n2)
        {
            this.number1 = n1;
            this.number2 = n2;
        }
    }
}
