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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        internal int time = 60;
        internal int iq = 250;
        string s;
        private void label3_Click(object sender, EventArgs e)
        {
            time -= 7;
            label3.Text = "减7秒";
            label3.ForeColor = Color.Red;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            time -= 7;
            label19.Text = "减7秒";
            label19.ForeColor = Color.Red;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            time -= 7;
            label5.Text = "减7秒";
            label5.ForeColor = Color.Red;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            time -= 7;
            label18.Text = "减7秒";
            label18.ForeColor = Color.Red;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            time -= 7;
            label13.Text = "减7秒";
            label13.ForeColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            time -= 7;
            label9.Text = "减7秒";
            label9.ForeColor = Color.Red;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            time -= 7;
            label15.Text = "减7秒";
            label15.ForeColor = Color.Red;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            time -= 7;
            label7.Text = "减7秒";
            label7.ForeColor = Color.Red;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            time -= 7;
            label11.Text = "减7秒";
            label11.ForeColor = Color.Red;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            time -= 7;
            label16.Text = "减7秒";
            label16.ForeColor = Color.Red;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            time -= 7;
            label14.Text = "减7秒";
            label14.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            time -= 7;
            label4.Text = "减7秒";
            label4.ForeColor = Color.Red;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            time -= 7;
            label8.Text = "减7秒";
            label8.ForeColor = Color.Red;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            time -= 7;
            label10.Text = "减7秒";
            label10.ForeColor = Color.Red;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            time -= 7;
            label12.Text = "减7秒";
            label12.ForeColor = Color.Red;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            time -= 7;
            label17.Text = "减7秒";
            label17.ForeColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            time -= 7;
            label6.Text = "减7秒";
            label6.ForeColor = Color.Red;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = time.ToString();
            if (time <= 0)
            {
                iq -= 50;
                LoseWin.LOSE(iq);
                (new Form12()).Show();
                this.Close();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            s += "T";
        }

        private void label24_Click(object sender, EventArgs e)
        {
            time -= 7;
            label24.Text = "减7秒";
            label24.ForeColor = Color.Red;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            s += "i";
        }

        private void label21_Click(object sender, EventArgs e)
        {
            time -= 7;
            label21.Text = "减7秒";
            label21.ForeColor = Color.Red;

        }

        private void label22_Click(object sender, EventArgs e)
        {
            time -= 7;
            label22.Text = "减7秒";
            label22.ForeColor = Color.Red;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            time -= 7;
            label20.Text = "减7秒";
            label20.ForeColor = Color.Red;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            s += "m";
        }

        private void label27_Click(object sender, EventArgs e)
        {
            s += "e";
            if (s == "Time")
            {
                LoseWin.Win(iq);
                (new EndForm()).Show();
                this.Close();
            }
            else
            {
                time -= 30;
                label27.Text = "减30秒";
                label27.ForeColor = Color.Red;
            }
        }
        
    }
}
