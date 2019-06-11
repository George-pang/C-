using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_猜拳游戏
{
    public class Computer
    {
        private string _fistName; //字段
        public string fistName //属性：存储当前电脑的出拳结果---用于给labelComputer赋值
        { 
            get { return _fistName; }
            set { _fistName = value; }
        }

        //电脑的出拳方法
        //1、剪刀
        //2、石头
        //3、布
        public int ShowFist() 
        {
            Random rd = new Random();
            int fist = rd.Next(1, 4); //利用Random类的Next()方法生成1-3之间的随机整数
            switch (fist) { 
                case 1:
                    this.fistName = "剪刀";
                    break;
                case 2:
                    this.fistName = "石头";
                    break;
                case 3:
                    this.fistName = "布";
                    break;
            }
            return fist;
        }
    }
}
