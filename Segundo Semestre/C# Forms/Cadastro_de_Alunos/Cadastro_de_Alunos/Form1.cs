using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //programa par que quando apertar o botão. o texto escrito em nome e em curso 
            //serão adicionados em ROW na dgv aluno
            dgvalunos.Rows.Add(txtNome.Text, txtCurso.Text);

            //após adicionar, limpe a caixinha para novas adições
            txtNome.Clear();
            txtCurso.Clear();

            //após isso, exiba uma mensagem que demonstre que a inclusão foi realizada sucess
            MessageBox.Show("Aluno incluido com sucesso", "Inclusão", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            
            //atualize a label total contando quantos Rows foram adicionados nela
            lblTotal.Text = dgvalunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica existência de linhas/inclusões feitas no row
            if (dgvalunos.Rows.Count > 0) 
            {
                //Remove a linha selecionada do Grid
                dgvalunos.Rows.RemoveAt(dgvalunos.CurrentCell.RowIndex);

                //Exibe uma mensagem ao usuário de 'Exclusão com sucesso'
                MessageBox.Show("Aluno excluido com sucesso", "Exclusão",
                                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Exibe na label o contador de linhas do GridView atualizado após a remoção 
                lblTotal.Text = dgvalunos.RowCount.ToString();
            }
        }

        private void dgvalunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificando se existem inclusoes no Row
            if (dgvalunos.RowCount> 0) 
            {
                //a célula de indice 0 vai ser trocada para o Text escrito em txt.Alterar
                //[0] pode ser também o nome da coluna de indice 0 "nome", os dois se referem
                txtAlterar.Text = dgvalunos.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //se a caixa de texto alterar não for vazia
            if (txtAlterar.Text != "") 
            {
                //a celula 0 ou nome vai ter seu valor alterado para o texto
                //escrito na caixa de texto alterar
                dgvalunos.CurrentRow.Cells[0].Value= txtAlterar.Text;

                //Exibe uma mensagem que mostra se foi alterado com sucesso
                MessageBox.Show("Aluno Alterado com sucesso", "Exclusão",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //define a contagem de alunos em row para 0
            dgvalunos.RowCount = 0;

            //atualiza a label text com o novo total de alunos
            lblTotal.Text = dgvalunos.RowCount.ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
