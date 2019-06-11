using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取中。。。");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写入中。。。");
        }
    }
}
