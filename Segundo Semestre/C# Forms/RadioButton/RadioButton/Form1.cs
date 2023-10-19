using System;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public string genero;
        public string pronome;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked)
            {
                MessageBox.Show("Gênero Masculino");
                genero = "M";
                pronome= "o";
            }


            else if (rdbFeminino.Checked)
            {
                MessageBox.Show("Gênero Feminino");
                genero = "F";
                pronome= "a";
            }

            else if (rdbNaoBinario.Checked)
            {
                MessageBox.Show("Gênero Não-Binário");
                genero = "NB";
                pronome = "e";
            }

            grbGenero.Enabled = false;
            grbEstadoCivil.Enabled = true;
            grbSexualidade.Enabled = false;
            rdbSolteiro.Text = "Solteir" + pronome;
            rdbViuvo.Text = "Viuv" + pronome;
            rdbDivorciado.Text = "Divorciad" + pronome;
            rdbCasado.Text = "Casad" + pronome;

        }

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            if (rdbSolteiro.Checked)
                MessageBox.Show("Você é Solteir" + pronome);

            else if (rdbDivorciado.Checked)
                MessageBox.Show("Você é Divorciad" + pronome);

            else if (rdbViuvo.Checked)
                MessageBox.Show("Você é Viuv" + pronome);

            else if (rdbCasado.Checked)
                MessageBox.Show("Você é Casad" + pronome);

            grbGenero.Enabled = false;
            grbEstadoCivil.Enabled = false;
            grbSexualidade.Enabled = true;

        }

        private void btnSexualidade_Click(object sender, EventArgs e)
        {
            if (genero == "M")
            {
                if (chkHomens.Checked && chkMulheres.Checked)
                    MessageBox.Show("Você é Bissexual");

                else if (chkHomens.Checked)
                    MessageBox.Show("Você é Gay");

                else if (chkMulheres.Checked)
                    MessageBox.Show("Você é Hetero");

                else
                    MessageBox.Show("Você é Assexual");
            }

            else if (genero == "F")
            {
                if (chkHomens.Checked && chkMulheres.Checked)
                    MessageBox.Show("Você é Bissexual");

                else if (chkHomens.Checked)
                    MessageBox.Show("Você é Hetero");

                else if (chkMulheres.Checked)
                    MessageBox.Show("Você é Lésbica");

                else
                    MessageBox.Show("Você é Assexual");
            }

            else if (genero == "NB")
            {
                if (chkHomens.Checked && chkMulheres.Checked)
                    MessageBox.Show("Não sei seu alinhamento, " +
                        "portanto apenas sei que você é bissexual");

                else if (chkHomens.Checked)
                    MessageBox.Show("Não sei seu alinhamento, " +
                        "portanto apenas sei que você é aquileano.");

                else if (chkMulheres.Checked)
                    MessageBox.Show("Não sei seu alinhamento, " +
                        "portanto apenas sei que você é sáfico");

                else
                    MessageBox.Show("Você é Assexual");
            }               

            rdbSolteiro.Text = "Solteiro(a)";
            rdbViuvo.Text = "Viuvo(a)";
            rdbDivorciado.Text = "Divorciado(a)";
            rdbCasado.Text = "Casado(a)";
            grbGenero.Enabled = true;
            grbEstadoCivil.Enabled = false;
            grbSexualidade.Enabled = false;
            chkMulheres.Checked = false;
            chkHomens.Checked = false;
            chkNenhum.Checked = false;
        }
    }
}
