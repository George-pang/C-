using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_自定义泛型
{ 
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //1、自定义泛型类
    public class Class1<T>  //泛型类
    {
        public void SayHello(T arg)
        {
            Console.WriteLine(arg);
        }
    }

    //2、自定义泛型方法
    public class Class2
    {
        public void SayHi<T>(T arg) //泛型方法
        {
            Console.WriteLine(arg);
        }
    }

    //3、自定义泛型接口
    public interface IFace<T>
    {
        T SayHi();
        void SayHello(T arg);
    }


    //实现泛型接口
    //1、普通类实现泛型接口
    public class Class3 : IFace<string>
    {
        public string SayHi()
        {
            throw new NotImplementedException();
        }

        public void SayHello(string arg)
        {
            throw new NotImplementedException();
        }
    }

    //2、泛型类实现泛型接口
    public class Class4<U> : IFace<U>
    {
        public U SayHi()
        {
            throw new NotImplementedException();
        }

        public void SayHello(U arg)
        {
            throw new NotImplementedException();
        }
    }



}
