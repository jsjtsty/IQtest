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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        bool i = false;
        int time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (i == false)
            {
                e.Cancel = true;
                i = true;
                LoseWin.Win(250, "\nTime,up!up!");
                (new Form12()).Show();
                this.Close();
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = true;
            this.Close();
        }
    }
}
