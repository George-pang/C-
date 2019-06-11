using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_通过抽象类实现多态
{
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
}
