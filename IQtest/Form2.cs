using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IQtest
{
    public partial class Form2 : Form
    {
        int weibi = 100;
        int iq = 250;
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weibi--;
            label4.Text = weibi.ToString();
            if (weibi <= 0)
            {
                if (weibi == 0)
                {
                    MessageBox.Show("拖拖窗口更健康……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SystemNumbers.money += 50;
                }
                else
                {
                    MessageBox.Show("拖拖窗口更健康……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.money >= 100)
            {
                SystemNumbers.money -= 100;
                label7.Text = SystemNumbers.money.ToString();
                MessageBox.Show("拖拖窗口更健康……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("金币不足！", "利诱", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.IsAdmin)
            {
                MessageBox.Show("拖动窗口，找到第二个按钮按下即可。", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("你没有足够的权限访问管理员专用通道！", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = SystemNumbers.money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iq-=50;
            LoseWin.LOSE(iq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IQ.iq1_1 = iq;
            LoseWin.Win(iq);
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
