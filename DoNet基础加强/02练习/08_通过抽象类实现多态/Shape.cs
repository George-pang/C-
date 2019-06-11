using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public abstract class Shape
    {
        public abstract void GetArea(); //抽象方法---求面积---方法参数在不同子类的构造函数中传递
        public abstract void GetGirth(); //抽象方法---求周长

    }
}
