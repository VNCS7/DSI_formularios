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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        bool pressed = false;

        private void button1_Click(object sender, EventArgs e)
        {
            int nm = System.Convert.ToInt16(textBox1.Text);
                if (pressed == true)
                {
                    nm = 0;

                }
               
                for (int i = 1; i <= nm; i++)
                {
                    richTextBox1.Text += i+" - Brasil\n";
                }

            }

        private void ex6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

            pressed = true;
        }

        }


    }
