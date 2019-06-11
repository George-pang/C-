using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_接口间的继承
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IF1
    {
        void Fly();
    }
    public interface IF2
    {
        void Swim();
    }
    public interface IF3
    {
        void Jump();
    }

    public interface ISuperMan : IF1, IF2, IF3 //ISuperMan接口多继承于IF1、IF2、IF3
    {
        void Fly(string name);//Fly方法的重载
    }
    public class SpiderMan : ISuperMan //SpiderMan类实现ISuperMan接口，要实现4个方法
    {
        public void Fly(string name)
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }
    }
}
