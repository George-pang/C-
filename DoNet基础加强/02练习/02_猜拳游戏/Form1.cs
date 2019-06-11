using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //三个按钮共用这一个事件处理函数---在按钮的属性-事件上设置
        private void button1_Click(object sender, EventArgs e) //sender 事件源（触发事件的对象）,e包含事件信息
        {
            User user = new User();
            Button btn = (Button)sender; //sender为当前触发事件的对象
            int userFist = user.ShowFist(btn.Text);
            labelUser.Text = user.fistName;

            Computer computer = new Computer();
            int computerFist = computer.ShowFist();
            labelComputer.Text = computer.fistName;

            Judge judge = new Judge();
            string result = judge.IsUserWin(userFist, computerFist);
            labelResult.Text = result;

        }
    }
}
