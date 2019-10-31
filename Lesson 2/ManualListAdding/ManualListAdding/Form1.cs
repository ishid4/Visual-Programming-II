using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualListAdding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListBox list = new ListBox();
        int sayac = 0;
        List<TextBox> textboxlar = new List<TextBox>();
        private void Form1_Load(object sender, EventArgs e)
        {
            list.SetBounds(325, 50, 100, 125);
            this.Controls.Add(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox yenitext = new TextBox();
            sayac += 40;
            yenitext.Location = new System.Drawing.Point(20, sayac);
            yenitext.Size = new System.Drawing.Size(125, 25);
            this.Controls.Add(yenitext);
            textboxlar.Add(yenitext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TextBox veriler in textboxlar)
            {
                list.Items.Add(veriler.Text);
            }
        }
    }
}
