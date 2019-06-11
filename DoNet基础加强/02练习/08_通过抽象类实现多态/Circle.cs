using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public class Circle:Shape
    {
        //构造函数---传参
        public Circle(double r)
        {
            this.R = r;
        }
        public double R { get; set; }

        public override void GetArea()
        {
            Console.WriteLine("圆的面积为：{0}",Math.PI*this.R*this.R);
        }

        public override void GetGirth()
        {
            Console.WriteLine("圆的周长为：{0}", 2*Math.PI * this.R);
        }
    }
}
