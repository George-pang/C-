using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_JiSuanQi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbCaoZuoFu.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textNum1.Text);
            int num2 = int.Parse(textNum2.Text);
            switch(cmbCaoZuoFu.Text){
                case "+":
                    labelResut.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    labelResut.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    labelResut.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    labelResut.Text = (num1 / num2).ToString();
                    break;
                default:
                    labelResut.Text = "未知结果！";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCaoZuoFu.SelectedIndex = 0;
        }
    }
}
