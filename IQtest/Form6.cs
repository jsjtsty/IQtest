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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        bool l6 = true;
        private void Form6_Load(object sender, EventArgs e)
        {
            IQ.iq2_1 = 250;
            string diq;
            decimal level1_iq = (IQ.iq1_1 + IQ.iq1_2 + IQ.iq1_3 + IQ.iq1_4) / 4;
            if (level1_iq < 150)
            {
                diq = "你的IQ过低，平均只有" + level1_iq.ToString() + "！\n是否进入待定关卡，获取最后的机会？";
                DialogResult IsGo = MessageBox.Show(diq, "低IQ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (IsGo == DialogResult.Yes)
                {
                    tabControl1.Hide();
                    l6 = false;
                    Level2_Go go = new Level2_Go();
                    go.Show();
                }
                else if (IsGo == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void Form6_MouseEnter(object sender, EventArgs e)
        {
            if (l6)
            {
            }
            else
            {
                this.Hide();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            IQ.iq2_1 -= 200;
            LoseWin.LOSE(IQ.iq2_1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoseWin.Win(IQ.iq2_1);
            Form7 a = new Form7();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.IsAdmin)
            {
                MessageBox.Show("点那行蓝色的字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("你没有足够的权限访问管理员专用通道！", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 a = new Form4();
            a.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 a = new Form5();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 a = new Form6();
            a.Show();
        }
    }
}
