using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_foreach循环
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //自定义Person类，现在可使用foreach遍历
            Person per = new Person();
            foreach (var item in per)  //foearch遍历是只读的，因为枚举器中的Current属性只有get函数
            {
                Console.WriteLine(item);
            }
            System.Console.WriteLine("OK");


            ////也可以使用枚举器内部的方法来遍历
            //Person p = new Person();
            //IEnumerator ie = p.GetEnumerator();
            //while (ie.MoveNext()) {
            //    Console.WriteLine(ie.Current.ToString());
            //}
            //ie.Reset(); //重置
            //Console.WriteLine("遍历重置：");
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current.ToString());
            //}
            //Console.WriteLine("OK");

            Console.ReadKey();
        }

    }

    //让一个类型实现IEnumerable接口，实现该接口的主要目的是为了该类型中增加一个GetEnumerator()方法，返回一个“枚举器”
    public class Person : IEnumerable
    {
        private string[] names = new string[] { "丁海", "林陶钧", "陈瑞", "庞陆强", "路永进", "寻瑶" };
        public string name { get; set; }
        public IEnumerator GetEnumerator() //该方法返回一个枚举器
        {
            return new PersonIEnumerator(names); //调用PersonIEnumerator类构造函数，返回一个枚举器
        }
    }

    //定义一个枚举器
    //PersonIEnumerator实现了IEnumerator接口，是一个枚举器
    public class PersonIEnumerator : IEnumerator
    {
        //构造函数
        public PersonIEnumerator(string[] arg)
        {
            _names = arg;
        }
        //字段
        private string[] _names;
        //定义索引下标字段，一般下标都是第一条的前一条
        private int index = -1;

        #region IEnumerator成员

        public object Current
        {
            get  //只读的，只有get函数
            {
                if (index >= 0 && index < _names.Length)
                {
                    return _names[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public bool MoveNext()
        {
            while (index < _names.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        #endregion

    }
}
