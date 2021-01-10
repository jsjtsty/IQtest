using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace IQtest
{
    public partial class Form5 : Form
    {
        int weibi = 155;
        
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            label7.Text = SystemNumbers.money.ToString();
            IQ.iq1_4 = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 5;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IQ.iq1_4 -= 300;
            LoseWin.LOSE(IQ.iq1_4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoseWin.Win(IQ.iq1_4);
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            weibi--;
            label4.Text=weibi.ToString();
            if (weibi <= 0)
            {
                if (weibi == 0)
                {
                    SystemNumbers.money += 30;
                    MessageBox.Show("再看看吧……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("再看看吧……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.money >= 100)
            {
                SystemNumbers.money -= 100;
                MessageBox.Show("再看看吧……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("金币不足！", "利诱", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.IsAdmin)
            {
                MessageBox.Show("单击蓝色按钮。", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("你没有足够的权限访问管理员专用通道！", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }
        
        
    }
}
