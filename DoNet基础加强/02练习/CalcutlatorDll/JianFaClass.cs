using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcutlatorDll
{
    public class JianFaClass:Calculator
    {
        public override double JiSuan()
        {
            return this.number1 - this.number2;
        }

        public JianFaClass(double n1,double n2):base(n1,n2)
        {
        }
    }
}
