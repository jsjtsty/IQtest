using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace IQtest
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        float time1 = 0.0f;
        float time2 = 0.0f;
        private void Form10_MouseEnter(object sender, EventArgs e)
        {
            time1 = 0.0f;
            timer1.Enabled = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            time2 = 0.0f;
            timer2.Enabled = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            time2 = 0.0f;
            timer2.Enabled = false;
            label5.Text = "0.0";
            label5.ForeColor = Color.Red;
        }

        private void Form10_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            time1 = 0.0f;
            label3.Text = "0.0";
            label3.ForeColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1 += 0.1f;
            time1 = (float)Math.Round((double)time1, 1, MidpointRounding.AwayFromZero);
            label3.Text = time1.ToString();
            if (time1 <= 10.0f)
            {
                label3.ForeColor = Color.Red;
            }
            else if (time1 > 10.0f && time1 <= 30.0f)
            {
                label3.ForeColor = Color.Orange;
            }
            else if (time1 > 30.0f && time1 <= 55.0f)
            {
                label3.ForeColor = Color.Blue;
            }
            else
            {
                label3.ForeColor = Color.Green;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2 += 0.1f;
            time2 = (float)Math.Round((double)time2, 1, MidpointRounding.AwayFromZero);
            label5.Text = time2.ToString();
            if (time2 <= 3.0f)
            {
                label5.ForeColor = Color.Red;
            }
            else if (time2 > 3.0f && time2 <= 7.0f)
            {
                label5.ForeColor = Color.Orange;
            }
            else if (time2 > 7.0f && time2 <= 12.0f)
            {
                label5.ForeColor = Color.Blue;
            }
            else if (time2 > 12.0f && time2 <= 17.0f)
            {
                label5.ForeColor = Color.Green;
            }
            else
            {
                LoseWin.Win(250);
                (new Form11()).Show();
                this.Close();
            }
        }
    }
}
