using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    class RealDuck:Duck
    {
        public override void Bark()
        {
            Console.WriteLine("小黄鸭子嘎嘎叫！");
        }
    }
}
