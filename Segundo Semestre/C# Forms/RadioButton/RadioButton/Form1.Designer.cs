namespace RadioButton
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbNaoBinario = new System.Windows.Forms.RadioButton();
            this.btnGenero = new System.Windows.Forms.Button();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.rdbViuvo = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.btnEstadoCivil = new System.Windows.Forms.Button();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.chkHomens = new System.Windows.Forms.CheckBox();
            this.chkMulheres = new System.Windows.Forms.CheckBox();
            this.chkNenhum = new System.Windows.Forms.CheckBox();
            this.btnSexualidade = new System.Windows.Forms.Button();
            this.grbSexualidade = new System.Windows.Forms.GroupBox();
            this.grbGenero.SuspendLayout();
            this.grbEstadoCivil.SuspendLayout();
            this.grbSexualidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(24, 49);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(178, 49);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbNaoBinario
            // 
            this.rdbNaoBinario.AutoSize = true;
            this.rdbNaoBinario.Location = new System.Drawing.Point(305, 49);
            this.rdbNaoBinario.Name = "rdbNaoBinario";
            this.rdbNaoBinario.Size = new System.Drawing.Size(80, 17);
            this.rdbNaoBinario.TabIndex = 2;
            this.rdbNaoBinario.TabStop = true;
            this.rdbNaoBinario.Text = "Não-Binário";
            this.rdbNaoBinario.UseVisualStyleBackColor = true;
            // 
            // btnGenero
            // 
            this.btnGenero.Location = new System.Drawing.Point(107, 80);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(181, 60);
            this.btnGenero.TabIndex = 3;
            this.btnGenero.Text = "Escolha o Gênero";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(105, 41);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rdbSolteiro.TabIndex = 4;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro(a)";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(105, 234);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(88, 17);
            this.rdbDivorciado.TabIndex = 5;
            this.rdbDivorciado.TabStop = true;
            this.rdbDivorciado.Text = "Divorciado(a)";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdbViuvo
            // 
            this.rdbViuvo.AutoSize = true;
            this.rdbViuvo.Location = new System.Drawing.Point(105, 168);
            this.rdbViuvo.Name = "rdbViuvo";
            this.rdbViuvo.Size = new System.Drawing.Size(64, 17);
            this.rdbViuvo.TabIndex = 6;
            this.rdbViuvo.TabStop = true;
            this.rdbViuvo.Text = "Viúvo(a)";
            this.rdbViuvo.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(105, 102);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(73, 17);
            this.rdbCasado.TabIndex = 7;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado(a)";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // btnEstadoCivil
            // 
            this.btnEstadoCivil.Location = new System.Drawing.Point(44, 276);
            this.btnEstadoCivil.Name = "btnEstadoCivil";
            this.btnEstadoCivil.Size = new System.Drawing.Size(223, 81);
            this.btnEstadoCivil.TabIndex = 8;
            this.btnEstadoCivil.Text = "Qual seu Estado Cívil";
            this.btnEstadoCivil.UseVisualStyleBackColor = true;
            this.btnEstadoCivil.Click += new System.EventHandler(this.btnEstadoCivil_Click);
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.btnGenero);
            this.grbGenero.Controls.Add(this.rdbNaoBinario);
            this.grbGenero.Controls.Add(this.rdbFeminino);
            this.grbGenero.Controls.Add(this.rdbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(9, 19);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(411, 152);
            this.grbGenero.TabIndex = 9;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Genero";
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.btnEstadoCivil);
            this.grbEstadoCivil.Controls.Add(this.rdbCasado);
            this.grbEstadoCivil.Controls.Add(this.rdbViuvo);
            this.grbEstadoCivil.Controls.Add(this.rdbDivorciado);
            this.grbEstadoCivil.Controls.Add(this.rdbSolteiro);
            this.grbEstadoCivil.Enabled = false;
            this.grbEstadoCivil.Location = new System.Drawing.Point(483, 19);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(305, 383);
            this.grbEstadoCivil.TabIndex = 10;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estado Civil";
            // 
            // chkHomens
            // 
            this.chkHomens.AutoSize = true;
            this.chkHomens.Location = new System.Drawing.Point(29, 36);
            this.chkHomens.Name = "chkHomens";
            this.chkHomens.Size = new System.Drawing.Size(65, 17);
            this.chkHomens.TabIndex = 11;
            this.chkHomens.Text = "Homens";
            this.chkHomens.UseVisualStyleBackColor = true;
            // 
            // chkMulheres
            // 
            this.chkMulheres.AutoSize = true;
            this.chkMulheres.Location = new System.Drawing.Point(29, 59);
            this.chkMulheres.Name = "chkMulheres";
            this.chkMulheres.Size = new System.Drawing.Size(69, 17);
            this.chkMulheres.TabIndex = 12;
            this.chkMulheres.Text = "Mulheres";
            this.chkMulheres.UseVisualStyleBackColor = true;
            // 
            // chkNenhum
            // 
            this.chkNenhum.AutoSize = true;
            this.chkNenhum.Location = new System.Drawing.Point(29, 82);
            this.chkNenhum.Name = "chkNenhum";
            this.chkNenhum.Size = new System.Drawing.Size(183, 17);
            this.chkNenhum.TabIndex = 13;
            this.chkNenhum.Text = "Nenhum (selecione apenas esse)";
            this.chkNenhum.UseVisualStyleBackColor = true;
            // 
            // btnSexualidade
            // 
            this.btnSexualidade.Location = new System.Drawing.Point(59, 120);
            this.btnSexualidade.Name = "btnSexualidade";
            this.btnSexualidade.Size = new System.Drawing.Size(291, 53);
            this.btnSexualidade.TabIndex = 15;
            this.btnSexualidade.Text = "DESCUBRA SUA SEXUALIDADE";
            this.btnSexualidade.UseVisualStyleBackColor = true;
            this.btnSexualidade.Click += new System.EventHandler(this.btnSexualidade_Click);
            // 
            // grbSexualidade
            // 
            this.grbSexualidade.Controls.Add(this.chkNenhum);
            this.grbSexualidade.Controls.Add(this.btnSexualidade);
            this.grbSexualidade.Controls.Add(this.chkMulheres);
            this.grbSexualidade.Controls.Add(this.chkHomens);
            this.grbSexualidade.Enabled = false;
            this.grbSexualidade.Location = new System.Drawing.Point(12, 203);
            this.grbSexualidade.Name = "grbSexualidade";
            this.grbSexualidade.Size = new System.Drawing.Size(408, 199);
            this.grbSexualidade.TabIndex = 16;
            this.grbSexualidade.TabStop = false;
            this.grbSexualidade.Text = "Sexualidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grbSexualidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.grbSexualidade.ResumeLayout(false);
            this.grbSexualidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbNaoBinario;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.RadioButton rdbViuvo;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.Button btnEstadoCivil;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.CheckBox chkHomens;
        private System.Windows.Forms.CheckBox chkMulheres;
        private System.Windows.Forms.CheckBox chkNenhum;
        private System.Windows.Forms.Button btnSexualidade;
        private System.Windows.Forms.GroupBox grbSexualidade;
    }
}

