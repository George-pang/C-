using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_猜拳游戏
{
    public class Judge
    {
        //方法：判断用户是否胜利
        //参数1：用户出拳结果对应的数字；参数2：电脑出拳结果对应的数字；
        //1、剪刀
        //2、石头
        //3、布
        public string IsUserWin(int user,int computer) {
            if (user == computer) {
                return "打平！";
            }
            else if (user - computer == -2 || user - computer == 1)
            {
                return "You Win！";
            }
            else {
                return "You Lost！";            
            }
        
        }
    }
}
