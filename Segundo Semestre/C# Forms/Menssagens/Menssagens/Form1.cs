using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menssagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("quer quer quer casar comigo", "RESPONDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não há quebra de contrato", "ACEITE", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amo", "As primeiras letras");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muito", "Entenda");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O meu namorado", "que é você");
        }

        private void btnExemplo1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você gostou da aula?", "Caixa de mensagem", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                txtSelecao.Text = "SIM";

            else
                txtSelecao.Text = "NÃO";
        }

        private void btnExemplo2_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Outro Exemplo", "Caixa de Mensagem",
                 MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

            if (resp == DialogResult.Abort)
                txtSelecao.Text = "ANULAR";

            else if (resp == DialogResult.Retry)
                txtSelecao.Text = "REPETIR";

            else
                txtSelecao.Text = "IGNORAR";
        }
    }
}
