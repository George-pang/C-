using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("鸭子水中游。。。");
        }

        public abstract void Bark();
    }
}
