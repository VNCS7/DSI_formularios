using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        double a = 1.50;
        double m = 1.10;
        double anos;


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; m < a; i++)
            {
                a += 0.02;
                m += 0.03;
                anos++;
            }
            richTextBox2.Text = "Serão necessários " + anos + " anos para manoel ser maior que arlindo";
        }

    }
}
