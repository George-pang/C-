using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public class Rectangle:Shape
    {
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int length { get; set; }
        public int width { get; set; }
        public override void GetArea()
        {
            Console.WriteLine("矩形的面积为：{0}", this.length * this.width);
        }

        public override void GetGirth()
        {
            Console.WriteLine("矩形的周长为：{0}", 2 * (this.length * this.width));
        }
    }
}
