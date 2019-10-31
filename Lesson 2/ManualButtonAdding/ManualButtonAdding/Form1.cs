using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualButtonAdding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.SetBounds(5, 6, 120, 120);
            btn.Text = "Tıkla";
            this.Controls.Add(btn);

            Label lbl = new Label();
            lbl.SetBounds(130, 130, 120, 120);
            lbl.Text = "Alo";
            this.Controls.Add(lbl);
        }
    }
}
