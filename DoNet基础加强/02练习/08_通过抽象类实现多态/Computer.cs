using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public class Computer
    {
        public MobileStorage dev { get; set; }
        public void PC_ReadData()
        {
            dev.Read();
        }
        public void PC_WriteData()
        {
            dev.Write();
        }
    }
}
