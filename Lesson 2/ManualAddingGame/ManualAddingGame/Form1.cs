using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualAddingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> buttons = new List<Button>();
        int sayi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();
                btn.Name = "Button" + i.ToString();
                btn.Text = btn.Name.ToString();
                btn.SetBounds(20, 70 * i, 60, 30);
                this.Controls.Add(btn);
                buttons.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.Visible = false;
            sayi++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi == 5)
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti");
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    buttons[i].SetBounds(rnd.Next(50, 250), rnd.Next(50, 250), 60, 30);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Start();
        }
    }
}
