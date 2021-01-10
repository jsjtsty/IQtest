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
    public partial class Level2_Go : Form
    {
        public Level2_Go()
        {
            InitializeComponent();
        }

        private void 进入Level21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IQ.iq1_1 = 250;
            IQ.iq1_2 = 250;
            IQ.iq1_3 = 250;
            IQ.iq1_4 = 250;
            MessageBox.Show("恭喜过关！", "通过", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form6 a = new Form6();
            a.Show();
        }
    }
}
