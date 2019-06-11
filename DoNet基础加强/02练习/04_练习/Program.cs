using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_继承练习
{
    class Program //默认访问修饰符为internal，类成员默认为private
    {
        static void Main(string[] args)
        {
        }
    }

    public class Father
    {
        public string lastName //自动属性
        {
            get;
            set;
        }
        public string property
        { get; set; }
        public string bloodType
        { get; set; }

        //构造函数---将默认的无参构造函数给覆盖掉啦
        public Father(string lastName, string property, string bloodType)
        {
            this.lastName = lastName;
            this.property = property;
            this.bloodType = bloodType;
        }
    }
    public class Son:Father
    {
        public void PlayGame() {
            Console.WriteLine("打游戏！");
        }

        //构造函数
        public Son(string lastName, string property, string bloodType)
            : base(lastName, property, bloodType)  //base调用父类中的有参构造函数
        {
            //this.lastName = lastName;
            //this.property = property;
            //this.bloodType = bloodType;
        }
    }
    public class Daughter : Father
    {
        public void Dance()
        {
            Console.WriteLine("跳舞！");
        }
       
        //构造函数
        public Daughter(string lastName, string property, string bloodType)
            : base(lastName, property, bloodType)
        {
            this.lastName = lastName;
            this.property = property;
            this.bloodType = bloodType;
        }
    }

}
