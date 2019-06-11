using CalcutlatorDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算测试
{
    class ChuFaClass:Calculator
    {
        public override double JiSuan()
        {
            return this.number1 / this.number2;
        }

        public ChuFaClass(double n1, double n2)
            : base(n1, n2)
        { 
        }
    }
}
