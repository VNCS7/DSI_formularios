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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTeste1 tst1 = new fmTeste1();
            tst1.MdiParent = this;
            tst1.Show();
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void teste2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            teste2 tst2 = new teste2();
            tst2.MdiParent = this;
            tst2.Show();
        }






    }
}
