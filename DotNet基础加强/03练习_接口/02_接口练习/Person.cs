using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_接口练习
{
    public class Person
    {
    }
    public interface ICollectHomeWork
    {
        void CollectHomeWork();
    }
    public class Student : Person,ICollectHomeWork
    {
        public void CollectHomeWork()
        {
            Console.WriteLine("学生收作业！");
        }
    }
    public class Teacher : Person,ICollectHomeWork
    {
        public void CollectHomeWork()
        {
            Console.WriteLine("老师收作业！");
        }
    }
    public class SchoolMaster : Person 
    { }

}
