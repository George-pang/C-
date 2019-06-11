using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_捕获多种异常
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int m = 10, n = 0;
                Console.WriteLine(m / n);
            }

            ////第一种:捕获所有异常--无法获取异常相关信息
            //catch
            //{
            //    Console.WriteLine("出现异常了。。。");
            //}

            ////第二种:捕获所有异常--可以获取异常信息
            //catch (Exception ex)
            //{
            //    Console.WriteLine("异常信息为：{0}",ex.Message);
            //}

            //第三种:捕获不同类型的异常---多个catch块
            //一段代码可能会生成多个异常当引发异常时，会按顺序来查看每个 catch 语句
            //并执行第一个类型与异常类型匹配的语句，其他的 catch 语句将被忽略。
            catch (NullReferenceException ex) //系统子类异常--空指针异常
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)  //系统子类异常--除数为0异常
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)      //系统子类异常--参数异常
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//系统基类异常--其余的所有异常
               //为什么不是捕获一次上面匹配的异常，然后再捕获一次这个所有异常呢
               //是因为即使有多个catch块，但是只捕获一次异常嘛
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
