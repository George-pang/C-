using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable bird = new IFlyable();//接口不能被实例化
            IFlyable bird = new Bird(); //子类可以赋给父类、父接口
            bird.Fly();

            Console.ReadKey();
        }
    }

    //接口不能被实例化---因为其中的方法没有实现
    //接口就是让子类来实现的

    //1、接口可以实现“多继承”（多实现）---一个类只能继承一个父类，但却可以继承多个接口
    //2、接口可以实现不同类型间的多态问题---比如鱼和船不是同一类型，但却都可以游水，只是实现的具体过程不同，要对“游水”实现多态，只能考虑接口
    
    //定义一个接口---一种能力的规范---建议以大写字母I开头
    public interface IFlyable
    {   //接口中只能定义方法
        //方法、属性、索引器、事件-->“方法”
        //接口中的所有成员，都不能显示的指定访问修饰符---默认是public

        //定义无参方法
        void Fly();

        //定义带参方法
        void Walk(string name);

        //定义一个未实现的属性--编译后生成get、set方法
        string age { get; set; }

        //定义一个索引器---编译后是一个叫item的属性
        string this[int index]
        {
            get;
            set;
        }
    }

    //子类只能继承一个父类（单根性）,但却可以继承多个接口
    //注意：接口中的成员，在子类中必须实现
    public class Bird : IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("鸟飞。。。");
        }

        public void Walk(string name)
        {
            Console.WriteLine("{0}在走。。。",name);
        }

        public string age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
