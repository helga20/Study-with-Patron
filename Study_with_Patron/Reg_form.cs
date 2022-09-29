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
    public partial class Reg_form : Form
    {
        public Reg_form()
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
            if (textBox1.Text != "")
            {
                Saper frm = new Saper();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Введи своє ім'я/нікнейм");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                Rating frm = new Rating();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Введи своє ім'я/нікнейм");
            }

        }
    }
}
