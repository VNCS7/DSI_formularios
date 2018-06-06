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
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }

        private void frmTeste1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void frmTeste1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nm1 = System.Convert.ToDouble(textBox1.Text);
            double nm2 = System.Convert.ToDouble(textBox2.Text);

            double result = nm1 + nm2;

            if (result > 20)
            {
                result += 8;
            }
            else if (result <= 20)
            {
                result -= 5;
            }


            textBox3.Text = result.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
