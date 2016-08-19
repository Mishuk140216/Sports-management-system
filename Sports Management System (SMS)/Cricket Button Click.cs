using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sports_Management_System__SMS_
{
    public partial class Cricket : Form
    {
        public Cricket()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cricket_Entry ce = new Cricket_Entry();
            ce.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cricket_Info ci = new Cricket_Info();
            ci.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cricket_Compare cc = new Cricket_Compare();
            cc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Schedule will be added here!!");
        }
    }
}
