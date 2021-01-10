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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        byte time = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = time.ToString();
            if (time == 0)
            {
                richTextBox1.Hide();
                label2.Show();
                label4.Show();
                textBox1.Show();
                button1.Show();
                timer1.Enabled = false;
                timer2.Enabled = true;
                label3.Text = "25";
                time = 25;
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label2.Text = @"　　1. The new term begins in September.
　　2. They are back to school, so they are unhappy.
　　3. They have five new subjects.
　　4. Lucy is good at English and Chinese.
　　5. Lucy can help me with my English.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToUpper() == "TFFFT")
            {
                MessageBox.Show("Win!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form9 i = new Form9();
                i.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("LOSE", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form8 i = new Form8();
                i.Show();
                this.Close();
            }
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = time.ToString();
            if (time == 0)
            {
                if (textBox1.Text.Trim().ToUpper() == "TFFFT")
                {
                    MessageBox.Show("Win!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    (new Form9()).Show();
                }
                else
                {
                    MessageBox.Show("LOSE", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form8 i = new Form8();
                    i.Show();
                    this.Close();
                }
            }
            timer2.Enabled = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            richTextBox1.Hide();
            label2.Show();
            label4.Show();
            textBox1.Show();
            button1.Show();
            buttonNext.Hide();
            timer1.Enabled = false;
            timer2.Enabled = true;
            label3.Text = "25";
            time = 25;
        }
    }
}
