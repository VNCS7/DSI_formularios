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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes = System.Convert.ToInt16(textBox1.Text);
            switch (mes)
            {
                case 1:
                    MessageBox.Show("Janeiro");
                    break;
                case 2:
                    MessageBox.Show("Fevereiro");
                    break;
                case 3:
                    MessageBox.Show("Março");
                    break;
                case 4:
                    MessageBox.Show("Abril");
                    break;
                case 5:
                    MessageBox.Show("Maio");
                    break;
                case 6:
                    MessageBox.Show("Junho");
                    break;
                case 7:
                    MessageBox.Show("Julho");
                    break;
                case 8:
                    MessageBox.Show("Agosto");
                    break;
                case 9:
                    MessageBox.Show("Setembro");
                    break;
                case 10:
                    MessageBox.Show("Outubro");
                    break;
                case 11:
                    MessageBox.Show("Novembro");
                    break;
                case 12:
                    MessageBox.Show("Dezembro");
                    break;
                default:
                    MessageBox.Show("Insira um número de 1 a 12");
                    break;
            }
        }

        private void ex4_Load(object sender, EventArgs e)
        {

        }

        private void ex4_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
