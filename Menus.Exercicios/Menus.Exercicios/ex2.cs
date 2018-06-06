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
    public partial class frmTeste2 : Form
    {
        public frmTeste2()
        {
            InitializeComponent();
        }

        private void frmTeste2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nm = System.Convert.ToDouble(textBox1.Text);

            if (nm % 10 == 0 && nm % 5 == 0 && nm % 2 == 0)
            {
                label2.Text = nm.ToString() + " é divisivel por 10,5 e 2.";
            }
            else if (nm % 10 == 0)
            {
                label2.Text = nm.ToString()+ " é divisivel por 10.";
            }
            else if (nm % 5 == 0)
            {
                label2.Text = nm.ToString() + " é divisivel por 5.";
            }
            else if (nm % 2 == 0)
            {
                label2.Text = nm.ToString() + " é divisivel por 2.";
            }
            else
            {
                label2.Text = nm.ToString() + " nao é divisivel por 10, 5 ou 2.";
            }


        }

        private void frmTeste2_Load(object sender, EventArgs e)
        {

        }
    }
}
