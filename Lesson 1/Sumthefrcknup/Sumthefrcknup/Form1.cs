using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumthefrcknup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int time = 0, time2 = 0;
        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            int num = rnd.Next(1000);
            textBox1.Text = num.ToString();
            num = rnd.Next(1000);
            textBox2.Text = num.ToString();

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) == Convert.ToInt32(textBox3.Text))
                {
                    timer1.Stop();
                    timer2.Start();
                    textBox4.Text = textBox3.Text;

                    int num = rnd.Next(1000);
                    textBox5.Text = num.ToString();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time++;
            label3.Text = time.ToString();
            if (time == 60)
            {
                time = 0;
                time2++;

                label4.Text = time2.ToString();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) == Convert.ToInt32(textBox6.Text))
                {
                    timer2.Stop();

                    int total1 = Convert.ToInt32(label1.Text) + Convert.ToInt32(label3.Text);
                    int total2 = Convert.ToInt32(label2.Text) + Convert.ToInt32(label4.Text);
                    label5.Text = total1.ToString();
                    label6.Text = total2.ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = time.ToString();
            if(time == 60)
            {
                time = 0;
                time2++;

                label1.Text = time2.ToString();
            }
        }
    }
}
