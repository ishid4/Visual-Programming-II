using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyValue.ToString());
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control == true)
            {
                MessageBox.Show("Control Key");
            }
            if (e.Alt)
            {
                MessageBox.Show("Alt Key");
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.B)
            {
                this.Close();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox6.TextLength == 10)
            {
                e.Handled = true;
                if(e.KeyChar == 8)
                {
                    e.Handled = false;
                }
            }
        }
    }
}
