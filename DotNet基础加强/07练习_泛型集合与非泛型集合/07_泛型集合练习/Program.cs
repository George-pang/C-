using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_泛型集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 使用泛型集合List<T>实现奇偶数分拣器
            string str = "2 7 8 3 22 9 5 11";
            List<string> listOdd = new List<string>();
            List<string> listEven = new List<string>();
            string[] numbers = str.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0)
                {
                    listEven.Add(numbers[i]);
                }
                else
                {
                    listOdd.Add(numbers[i]);
                }
            }
            listOdd.AddRange(listEven);
            string[] arr = listOdd.ToArray(); //将listOdd中元素复制到新数组中去
            string newStr = string.Join(" ", arr);
            Console.WriteLine(newStr);
            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region 将int数组中的奇数放到新的int数组中去
            int[] intArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list = new List<int>(); //C#里数组是不可以改变长度的，因此不能使用for循环动态添加元素，这里采用List<T>泛型集合
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i] % 2 != 0)
                {
                    list.Add(intArr[i]);
                }
            }
            int[] newArr = list.ToArray();
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
            Console.ReadKey();
            #endregion

            #region 从一个整数List<int>中找出最大数，别用Max方法

            Console.WriteLine();
            Console.WriteLine("从一个List<int>找出最大数：");
            List<int> list2 = new List<int>() { 1, 3, 5, 33, 9, 66, 99, 54 };
            //Console.WriteLine(list2.Max());
            Console.WriteLine(getMax(list2));
            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region 把123转为壹贰叁
            string strNum = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖";
            string[] strNumArr = strNum.Split(' ');
            Dictionary<char, char> dict = new Dictionary<char, char>();
            for (int i = 0; i < strNumArr.Length; i++)
            {
                dict.Add(strNumArr[i][0], strNumArr[i][1]);
            }
            Console.WriteLine("把123转为壹贰叁,请输入一个整数：");
            string inputNum = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < inputNum.Length; i++)
            {
                sb.Append(dict[inputNum[i]]);
            }
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region 计算字符串中每种字母出现的次数，不区分大小写
            string msg = "Hello! Welcome To MyWorld! sasjafjksandlanlll;;.,..am1l";
            msg = msg.ToLower();
            Dictionary<char, int> dict2 = new Dictionary<char, int>(); //声明一个Dictionary集合，键用作存字母，值用来存字母出现次数
            for (int i = 0; i < msg.Length; i++)
            {
                if (char.IsLetter(msg[i]))//判断是否是字母
                {
                    if (dict2.ContainsKey(msg[i]))  //若有，则出现次数++
                    {
                        dict2[msg[i]]++;
                    }
                    else  //若Dictionary集合中没有这个键，则添加
                    {
                        dict2.Add(msg[i], 1);
                    }
                }
            }
            foreach (KeyValuePair<char, int> item in dict2)
            {
                Console.WriteLine("字母{0}出现的次数为：{1}", item.Key, item.Value);
            }
            Console.WriteLine();
            Console.ReadKey();

            #endregion

            #region 日期转换：编写函数，将中文日期转为阿拉伯日期
            string strDate = "二零一九年十一月二十五日";
            strDate = DateConvert(strDate);
            Console.WriteLine(strDate);
            Console.ReadKey();

            #endregion
        }

        //日期转换
        private static string DateConvert(string strDate)
        {
            //声明一个Dictionary键值对集合--用来存储中文一到九对应的阿拉伯数字
            Dictionary<char, char> dict3 = new Dictionary<char, char>();
            string numStr = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            string[] numArr = numStr.Split(' ');
            for (int i = 0; i < numArr.Length; i++)
            {
                dict3.Add(numArr[i][0], numArr[i][1]);
            }

            StringBuilder sbStr = new StringBuilder();
            for (int i = 0; i < strDate.Length; i++)
            {
                if (strDate[i] == '十') //中文十
                {
                    if (dict3.ContainsKey(strDate[i - 1]) && dict3.ContainsKey(strDate[i + 1])) //如二十一日，此时十省略
                    {
                        sbStr.Append("");
                    }
                    else if (!dict3.ContainsKey(strDate[i - 1]) && !dict3.ContainsKey(strDate[i + 1])) //如十月，此时十对应数字10
                    {
                        sbStr.Append("10");
                    }
                    else if (dict3.ContainsKey(strDate[i - 1]) && !dict3.ContainsKey(strDate[i + 1])) //如二十日，此时十对应数字0
                    {
                        sbStr.Append("0");
                    }
                    else if (!dict3.ContainsKey(strDate[i - 1]) && dict3.ContainsKey(strDate[i + 1])) //如十一月，此时十对应数字1
                    {
                        sbStr.Append("1");
                    }
                }
                else if (dict3.ContainsKey(strDate[i])) //中文：一到九
                {
                    sbStr.Append(dict3[strDate[i]]);
                }
                else //中文字符：年、月、日
                {
                    sbStr.Append("-");
                }
            }

            return sbStr.Remove(sbStr.Length - 1, 1).ToString(); //去除最后一个字符（由‘日’转换的-）

        }


        //获取List<int>中的最大值
        private static int getMax(List<int> list2)
        {
            int MaxValue = list2[0];
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] > MaxValue)
                {
                    MaxValue = list2[i];
                }
            }
            return MaxValue;
        }
    }
}
