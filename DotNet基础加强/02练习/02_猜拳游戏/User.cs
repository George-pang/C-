using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_猜拳游戏
{
    public class User
    {
        private string _fistName;
        public string fistName    //存储当前用户的出拳结果---用于给labelUser赋值
        {
            get
            {
                return _fistName;
            }
            set
            {
                _fistName = value;
            }

        }
        
        
        //玩家的出拳方法
        //1、剪刀
        //2、石头
        //3、布
        public int ShowFist(string fist) 
        {
            this.fistName = fist;
            int result = -1;
            switch(fist){
                case "剪刀":
                    result = 1;
                    break;
                case "石头":
                    result = 2;
                    break;
                case "布":
                    result = 3;
                    break;
            }
            return result;
        }

    }
}
