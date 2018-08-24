using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoModulo03MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //message box simples
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta é uma caixa de texto simples!";
            MessageBox.Show(mensagem);
        }
        //messagebox com título
        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta é uma caixa de texto simples!";
            string titulo = "Título da mensagem";
            MessageBox.Show(mensagem, titulo);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta é uma caixa de texto simples!";
            string titulo = "Título da mensagem";
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            /*digitar todas as opções de botões nos comentarios!não esquecer
             okcancel
             retrycancel
             yesno
             yesnocancel


             */
            MessageBox.Show(mensagem, titulo, botoes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta é uma caixa de texto simples!";
            string titulo = this.Text;
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado;
            resultado = MessageBox.Show(mensagem, titulo, botoes);

            if(resultado == DialogResult.Yes)
            {
                MessageBox.Show("sim");
            }
            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Não");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensagem = "Esta é uma caixa de texto simples!";
            string titulo = this.Text;
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Warning;
            MessageBox.Show(mensagem, titulo, botoes, icone);



        }
    }
}
