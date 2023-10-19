using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_box
{
    public partial class Form1 : Form
    {
        double total;
        double valor;
        int quantidade;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtValor.Text = string.Empty;
            lstProduto.Items.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
             // Substitua "Produto a ser adicionado" pelo nome do produto que deseja adicionar.
             string produto = (txtProduto.Text +" | "+ txtQuantidade.Text + " | " + txtValor.Text); 
             lstProduto.Items.Add(produto); // Adiciona o produto à ListBox.

             valor = double.Parse(txtValor.Text);
             quantidade = int.Parse(txtQuantidade.Text);

             total += valor * quantidade;
             lblTotal.Text = total.ToString("C");
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
