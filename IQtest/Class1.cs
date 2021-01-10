using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IQtest
{
    class SystemNumbers
    {
        static public ulong money
        {
            get;
            set;
        }
        static public bool IsAdmin
        {
            get;
            set;
        }
        static public byte UsersBack
        {
            get;
            set;
        }
    }
    class IQ
    {
        static public int iq1_1
        {
            get;
            set;
        }
        static public int iq1_2
        {
            get;
            set;
        }
        static public int iq1_3
        {
            get;
            set;
        }
        static public int iq1_4
        {
            get;
            set;
        }
        static public int iq2_1
        {
            get;
            set;
        }
        static public int iq2_2
        {
            get;
            set;
        }
    }
    class LoseWin
    {
        static public void LOSE(int IQ)
        {
            string temp = "LOSE\nIQ:" + IQ.ToString();
            if (IQ > 0)
            {
                MessageBox.Show(temp, "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(temp, "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void LOSE(int IQ, string message)
        {
            string temp = "LOSE\nIQ:" + IQ.ToString() +"\n"+ message;
            if (IQ > 0)
            {
                MessageBox.Show(temp, "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(temp, "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public void Win(int IQ)
        {
            string temp = "Win!\nIQ:" + IQ.ToString();
            if (IQ > -150)
            {
                MessageBox.Show(temp, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(temp, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static public void Win(int IQ, string message)
        {
            string temp = "Win!\nIQ:" + IQ.ToString() + message;
            if (IQ > -150)
            {
                MessageBox.Show(temp, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(temp, "Win!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
