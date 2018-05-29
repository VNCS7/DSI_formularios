using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class fmTeste1 : Form
    {
        public fmTeste1()
        {
            InitializeComponent();
        }

        private void fmTeste1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }


        }

        private void fmTeste1_Load(object sender, EventArgs e)
        {

        }
    }
}
