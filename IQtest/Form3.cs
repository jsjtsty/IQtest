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
    public partial class Form3 : Form
    {
        int iq=250;
        int weibi = 25;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = SystemNumbers.money.ToString();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Hide();
            button3.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Show();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Show();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Hide();
            button6.Show();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Show();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Hide();
            button8.Show();
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.Hide();
            button9.Show();
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.Hide();
            button1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            weibi--;
            label4.Text = weibi.ToString();
            if (weibi <= 0)
            {
                SystemNumbers.money += 50;
                IQ.iq1_2 = iq;
                Form4 frm4 = new Form4();
                frm4.Show();
                this.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.money >= 100)
            {
                SystemNumbers.money -= 100;
                MessageBox.Show("去“威逼”吧，那里会让你心平气和……", "利诱提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LoseWin.Win(iq);
                Form4 frm4 = new Form4();
                this.Hide();
                frm4.Show();
            }
            else
            {
                MessageBox.Show("你没有足够的权限访问管理员专用通道！", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }
    }
}
