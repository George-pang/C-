using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public class MP3Player:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取中。。。");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入中。。。");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Music Playing....");
        }
    }
}
