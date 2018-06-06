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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoa = System.Convert.ToDouble(textBox1.Text);
            double ladob = System.Convert.ToDouble(textBox2.Text);
            double ladoc = System.Convert.ToDouble(textBox3.Text);

            if (ladoa == ladob && ladob == ladoc)
                textBox4.Text = "Valores informados formam\n um triângulo equilátero";
            else if (ladoa == ladob || ladoc == ladob || ladoc == ladoa)
                textBox4.Text = "Valores informados formam\n um triângulo isósceles";
            else if (ladoa != ladob && ladob != ladoc && ladoc != ladoa)
                textBox4.Text = "Valores informados formam\n um triângulo escaleno";



        }

    }
}
