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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        internal byte fen = 0;
        internal byte time = 20;
        internal byte zt = 1;
        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            switch (SystemNumbers.UsersBack)
            {
                case 1:
                    label4.Text += "30";
                    fen += 30;
                    break;
                case 2:
                    label4.Text += "15";
                    fen += 20;
                    break;
                case 3:
                    label4.Text += "25";
                    fen += 25;
                    break;
                case 4:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                time = 20;
                Level2_Start();
                //panel1.Visible = false;
                //panel2.Visible = true;
                zt++;
                label1.Text = "20";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time == 0)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
                time = 10;
                Level3_Start();
                if (checkBox3.Checked || checkBox7.Checked)
                {
                    if (checkBox3.Checked && checkBox7.Checked)
                        fen += 25;
                    else
                        fen += 20;
                }
                zt++;
                label1.Text = "10";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (zt)
            {
                case 1:
                    timer1.Enabled = false;
                    label1.Text = "20";
                    Level2_Start();
                    button1.Text = "下一题";
                    button1.ForeColor = Color.Black;
                    timer2.Enabled = true;
                    time = 20;
                    zt++;
                    break;
                case 2:
                    timer2.Enabled = false;
                    Level3_Start();
                    label1.Text = "10";
                    timer3.Enabled = true;
                    time = 10;
                    zt++;
                    if (checkBox3.Checked || checkBox7.Checked)
                    {
                        if (checkBox3.Checked && checkBox7.Checked)
                            fen += 25;
                        else
                            fen += 20;
                    }
                    break;
                case 3:
                    timer3.Enabled = false;
                    Level4_Start();
                    label1.Text = "10";
                    timer4.Enabled = true;
                    time = 10;
                    zt++;
                    if (checkBox8.Checked && checkBox9.Checked)
                        fen += 20;
                    break;
                case 4:
                    timer4.Enabled = false;
                    Level5_Start();
                    label1.Text = "5";
                    timer5.Enabled = true;
                    time = 5;
                    zt++;
                    if (textBox1.Text == "灰太宗")
                        fen += 10;
                    break;
                case 5:
                    timer5.Enabled = false;
                    if (progressBar1.Value != 13) ;
                    else
                        fen += 20;
                    if (fen < 60)
                    {
                        MessageBox.Show("LOSE\nScore:" + fen.ToString(), "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Form7 frm7 = new Form7();
                        frm7.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Win!\nScore:" + fen.ToString(), "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form8 a = new Form8();
                        a.Show();
                        this.Close();
                    }
                    break;
            }
        }
        #region 关卡预处理
        internal void Level2_Start()
        {
            label3.Hide();
            label4.Hide();
            label6.Show();
            checkBox1.Show();
            checkBox2.Show();
            checkBox3.Show();
            checkBox4.Show();
            checkBox5.Show();
            checkBox6.Show();
            checkBox7.Show();
        }
        internal void Level3_Start()
        {
            label6.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            label7.Show();
            checkBox8.Show();
            checkBox9.Show();
            checkBox10.Show();
            checkBox11.Show();
        }
        internal void Level4_Start()
        {
            label7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            label9.Show();
            label10.Show();
            textBox1.Show();
        }
        internal void Level5_Start()
        {
            label9.Hide();
            label10.Hide();
            textBox1.Hide();
            label11.Show();
            label12.Show();
            button2.Show();
            progressBar1.Show();
            button1.Text = "提交";
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time == 0)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
                zt++;
                time = 10;
                label1.Text = "10";
                if (checkBox8.Checked && checkBox9.Checked)
                    fen += 20;
                Level4_Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time == 0)
            {
                timer4.Enabled = false;
                zt++;
                time = 5;
                label1.Text = "5";
                if (textBox1.Text == "灰太宗")
                    fen += 10;
                Level5_Start();
                timer5.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = time.ToString();
            if (time == 0)
            {
                timer5.Enabled = false;
                if (progressBar1.Value != 13) ;
                else
                {
                    fen += 20;
                }
                if (fen < 60)
                {
                    MessageBox.Show("LOSE\nScore:" + fen.ToString(), "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form7 frm7 = new Form7();
                    frm7.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Win!\nScore:" + fen.ToString(), "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form8 a = new Form8();
                    a.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 13)
                progressBar1.PerformStep();
            else ;
            label12.Text = (progressBar1.Value*100/13).ToString() + "%";
        }
    }
}
