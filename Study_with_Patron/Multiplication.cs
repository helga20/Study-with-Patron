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
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

        int counter = 0;
        int max = 0;

        public char GetModul()
        {
            Random rnd = new Random();
            string chars = "*/";
            int num = rnd.Next(0, 2);
            char modul = chars[num];
            return modul;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = 10;
            button1.Visible = false;
            Random rnd = new Random();
            int a = rnd.Next(1, max);
            int b = rnd.Next(1, max);
            char modul = GetModul();
            if (modul == '/')
            {
                if (a % b != 0)
                {
                    a = rnd.Next(1, max);
                    b = rnd.Next(1, max);
                }
            }
            if (a < b && modul == '/')
            {
                int temp = a;
                a = b;
                b = temp;
                if(a%b != 0)
                {
                    a = rnd.Next(1, max);
                    b = rnd.Next(1, max);
                }
            }
            label1.Text = a.ToString();
            label3.Text = modul.ToString();
            label4.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введи свою відповідь)");
            }
            else
            {
                string var; var = textBox1.Text;
                int res = Convert.ToInt32(var);
                int a = Convert.ToInt32(label1.Text);
                int b = Convert.ToInt32(label4.Text);
                if (res == a * b || res == a / b)
                {
                    textBox1.Text = "";
                    Random rnd = new Random();
                    int a_1 = rnd.Next(1, max);
                    int b_1 = rnd.Next(1, max);
                    char modul = GetModul();
                    if (modul == '/')
                    {
                        if (a % b != 0)
                        {
                            a = rnd.Next(1, max);
                            b = rnd.Next(1, max);
                        }
                    }
                    if (a < b && modul == '/')
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                        if (a % b != 0)
                        {
                            a = rnd.Next(1, max);
                            b = rnd.Next(1, max);
                        }
                    }
                    label1.Text = a_1.ToString();
                    label3.Text = modul.ToString();
                    label4.Text = b_1.ToString();

                    counter++;
                    label5.Text = "Вдалось - " + counter;

                }
                else
                {
                    button2.Visible = true;
                    counter--;
                    label5.Text = "Вдалось - " + counter;
                }
                if (counter == 15)
                {
                    button3.Visible = true;
                }
                if (counter == 30)
                {
                    MessageBox.Show("Вітаю ти пройшов урок");
                    Begin_work frm = new Begin_work();
                    this.Hide();
                    frm.Show();
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            max = 100;
            this.Hide();
            this.Show();
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            textBox1.Text = "";
            Random rnd = new Random();
            int a = rnd.Next(1, max);
            int b = rnd.Next(1, max);
            char modul = GetModul();
            if (modul == '/')
            {
                if (a % b != 0)
                {
                    a = rnd.Next(1, max);
                    b = rnd.Next(1, max);
                }
            }
            if (a < b && modul == '/')
            {
                int temp = a;
                a = b;
                b = temp;
                if (a % b != 0)
                {
                    a = rnd.Next(1, max);
                    b = rnd.Next(1, max);
                }
            }
            label1.Text = a.ToString();
            label3.Text = modul.ToString();
            label4.Text = b.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Begin_work frm = new Begin_work();
            this.Hide();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "1";
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "2";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "3";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Begin_work frm = new Begin_work();
            this.Hide();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
