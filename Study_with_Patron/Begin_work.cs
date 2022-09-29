using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_with_Patron
{
    public partial class Begin_work : Form
    {
        public Begin_work()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start frm = new Start();
            this.Hide();
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addition frm = new Addition();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multiplication frm = new Multiplication();
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg_form frm = new Reg_form();
            this.Hide();
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Start frm = new Start();
            this.Hide();
            frm.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
