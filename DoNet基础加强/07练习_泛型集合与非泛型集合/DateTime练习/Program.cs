using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeStr = "2019-05-20 08:30:33";

            try
            {
                DateTime dt = Convert.ToDateTime(timeStr);
                Console.WriteLine(dt); //Convert.ToDateTime()与dt.ToString()当未指定日期时间格式时，转换后的值与系统日期时间格式有关
                Console.WriteLine(dt.ToString());//dt.ToString()当未指定日期时间格式时，转换后的值与系统日期时间格式有关
                Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss")); //指定ToString()的日期时间格式
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
