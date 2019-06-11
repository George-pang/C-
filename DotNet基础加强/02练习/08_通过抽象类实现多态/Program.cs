using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.SayHi();

            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Eat();
            dog.Bark();
            cat.Eat();
            cat.Bark();

            Shape shape = new Circle(10);//子类可以赋给父类
            Shape shape1 = new Rectangle(20, 10);
            shape.GetArea();
            shape1.GetArea();
            shape.GetGirth();
            shape1.GetGirth();

            Computer pc = new Computer();
            //pc.dev = new UDisk();
            //pc.dev = new MobileDisk();
            pc.dev = new MP3Player();
            pc.PC_ReadData();
            pc.PC_WriteData();

            Duck duck = new RubberDuck();
            duck.Swim();
            duck.Bark();
            Duck duck2 = new RealDuck();
            duck2.Swim();
            duck2.Bark();

            Console.ReadKey();
        }

        //3、抽象成员必须包含在抽象类中
        //4、抽象类不能用来实例化对象，抽象类的作用就是为了实现“继承”，继承的主要目的就是为了实现多态
        //5、子类继承抽象类后，子类中必须“重写”override抽象成员，除非子类也是抽象类
        public abstract class Person
        {
            //1、抽象类中既可以有抽象成员，也可以有实例成员
            public string name { get; set; }
            //2、抽象成员不能有任何实现---方法体
            public abstract void SayHi();
        }

        public class Student : Person
        {
            //子类中重写父类中的抽象成员
            public override void SayHi() 
            {
                Console.WriteLine("这是子类中的SayHi方法");
            }        
        }

        //除非子类本身也是抽象类
        public  abstract class Teacher : Person
        { 
        
        }

        public abstract class Animal
        {
            public abstract void Eat();
            public abstract void Bark();
        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("狗吃骨头！");
            }

            public override void Bark()
            {
                Console.WriteLine("汪汪汪！");
            }
        }

        public class Cat : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("猫吃鱼！");
            }

            public override void Bark()
            {
                Console.WriteLine("喵喵喵！");
            }
        }
    }
}
