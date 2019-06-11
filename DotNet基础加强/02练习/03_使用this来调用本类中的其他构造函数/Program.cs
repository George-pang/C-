using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_使用this来调用本类中的其他构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Person
    {
        public string name
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
        public string gender
        {
            get;
            set;
        }
        public int height
        {
            get;
            set;
        }
    }

    public class Student : Person
    {
        public Student(string name, string gender, int age, int height)
            : base()//:base()调用父类中无参的构造函数
        { 
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.height = height;
        }
        public Student(string name, int age)
            : this(name, null, age, 0)//:this() 调用本类中的其他构造函数
        {  

        }

    }
}
