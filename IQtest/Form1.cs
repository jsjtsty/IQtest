using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace IQtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if(textBox1.Text=="sty@20030209")
                {
                    SystemNumbers.money=999999999999;
                    SystemNumbers.UsersBack=1;
                    SystemNumbers.IsAdmin=true;
                    Form2 a=new Form2();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Text="";
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text == "12301231551ywt")
                {
                    SystemNumbers.IsAdmin = false;
                    SystemNumbers.money = 95;
                    SystemNumbers.UsersBack = 2;
                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }
            else if (radioButton3.Checked)
            {
                if (textBox1.Text == "ChengHao")
                {
                    SystemNumbers.money = 100;
                    SystemNumbers.IsAdmin = false;
                    SystemNumbers.UsersBack = 3;
                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }
            else
            {
                SystemNumbers.IsAdmin = false;
                SystemNumbers.money = 0;
                SystemNumbers.UsersBack = 4;
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出？", "IQtest", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
