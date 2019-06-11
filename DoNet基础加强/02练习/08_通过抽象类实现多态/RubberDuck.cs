using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    class RubberDuck:Duck
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫！");
        }
    }
}
