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
    public partial class Form4 : Form
    {
        int weibi = 155;
        bool bt1_jh = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label7.Text = SystemNumbers.money.ToString();
            IQ.iq1_3 = 250;
            tabPage4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                IQ.iq1_3 -= 210;
                LoseWin.LOSE(IQ.iq1_3, "提示：哎哟，别说假话啦！偶才不信呢！");
            }
            else if (radioButton2.Checked)
            {
                IQ.iq1_3 -= 115;
                LoseWin.LOSE(IQ.iq1_3, "提示：哎哟，开始早恋了哈，赶紧打掉这个念头！");
            }
            else if (radioButton3.Checked)
            {
                IQ.iq1_3 -= 1205;
                LoseWin.LOSE(IQ.iq1_3, "提示：我已经木有什么话可以说了。");
            }
            else if (radioButton4.Checked)
            {
                LoseWin.Win(IQ.iq1_3, "提示：沉默是最好的回答……");
                Form5 frm5 = new Form5();
                this.Hide();
                frm5.Show();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (bt1_jh)
            {
            }
            else
            {
                button1.Hide();
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (bt1_jh)
            {
            }
            else
            {
                button1.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            weibi--;
            label4.Text = weibi.ToString();
            if (weibi <= 0)
            {
                if (weibi == 0)
                {
                    SystemNumbers.money += 20;
                    MessageBox.Show("有的时候，偶的通道也是可以闯闯的……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("有的时候，偶的通道也是可以闯闯的……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.money >= 100)
            {
                SystemNumbers.money -= 100;
                MessageBox.Show("有的时候，偶的通道也是可以闯闯的……", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("金币不足！", "利诱", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabPage4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == "ZKW4")
            {
                IQ.iq1_3 -= 50;
                LoseWin.LOSE(IQ.iq1_3, "提示：唉，真傻，还真的输入“ZKW4”呢。在这个游戏里，你不知道这是作死吗？");
            }
            else
            {
                bt1_jh = true;
                tabPage4.Hide();
                MessageBox.Show("恭喜输入正确！不过，似乎问题页和以前不一样了呢……", "输入正确", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SystemNumbers.IsAdmin)
            {
                MessageBox.Show("先单击管理员专用通道，输入错误的验证码，再返回问题页选择“其他”后提交即可。", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("你没有足够的权限访问答案！", "管理员专用通道", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }
    }
}
