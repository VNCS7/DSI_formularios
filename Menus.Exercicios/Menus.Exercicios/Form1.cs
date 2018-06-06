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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1(); //criando uma instância do formulário teste1
            tst1.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            tst1.Show();                      //esta linha exibe o formulário teste1

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 tst2 = new frmTeste2(); //criando uma instância do formulário teste1
            tst2.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            tst2.Show();                      //esta linha exibe o formulário teste2
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void arquivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ex3 EXERCICIO3 = new ex3(); //criando uma instância do formulário teste1
            EXERCICIO3.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            EXERCICIO3.Show();   
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ex4 EXERCICIO4 = new ex4(); //criando uma instância do formulário teste1
            EXERCICIO4.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            EXERCICIO4.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ex5 EXERCICIO5 = new ex5(); //criando uma instância do formulário teste1
            EXERCICIO5.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            EXERCICIO5.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ex6 EXERCICIO6 = new ex6(); //criando uma instância do formulário teste1
            EXERCICIO6.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            EXERCICIO6.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ex7 EXERCICIO7 = new ex7(); //criando uma instância do formulário teste1
            EXERCICIO7.MdiParent = this;            //esta linha define que a instância do forumlário criado é "filho" do formulário principal
            EXERCICIO7.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

    }
}
