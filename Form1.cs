using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 随机出题_四则运算_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        proplem p = new proplem();
        int result;
        string str = "";
        int n;
        int a = 0, b = 0, c = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(0);
            double s;
            textBox1.Clear();
            s = 100 * b / a;
            listBox1.Items.Add("题目数：" + a + ",正确题目数：" + b + ",错误题目数：" + c);
            listBox1.Items.Add("你的正确率：" + Math.Round(s, 0) +"%");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            listBox1.Items.Clear();
            a = 0;
            b = 0;
            c = 0;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            str = p.Proplem(str, out result);
            textBox1.Text = str;
            textBox2.Text =Convert.ToString(0);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            n = Convert.ToInt32(textBox2.Text);
            if (result == n)
             { 
                listBox1.Items.Add(str + textBox2.Text +" "+ "正确");
                a++;
                b++;
            }
            else
            {
                listBox1.Items.Add(str + textBox2.Text +" "+ "错误");
                a++;
                c++;
            }
            Form1_Load(sender, e);
            textBox2.Text = Convert.ToString(0);
        }

    }
}
