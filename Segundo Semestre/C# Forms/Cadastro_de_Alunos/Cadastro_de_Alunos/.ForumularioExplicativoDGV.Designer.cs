namespace Cadastro_de_Alunos
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtAlterar = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvalunos = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterarNome = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(95, 49);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(314, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // txtAlterar
            // 
            this.txtAlterar.Location = new System.Drawing.Point(136, 323);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(212, 20);
            this.txtAlterar.TabIndex = 2;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(95, 87);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(136, 45);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "INCLUIR";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(247, 87);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(162, 45);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvalunos
            // 
            this.dgvalunos.AllowUserToAddRows = false;
            this.dgvalunos.AllowUserToDeleteRows = false;
            this.dgvalunos.AllowUserToOrderColumns = true;
            this.dgvalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.CURSO});
            this.dgvalunos.Location = new System.Drawing.Point(95, 156);
            this.dgvalunos.Name = "dgvalunos";
            this.dgvalunos.ReadOnly = true;
            this.dgvalunos.Size = new System.Drawing.Size(314, 145);
            this.dgvalunos.TabIndex = 5;
            this.dgvalunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalunos_CellClick);
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // CURSO
            // 
            this.CURSO.HeaderText = "CURSO";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            // 
            // btnAlterarNome
            // 
            this.btnAlterarNome.Location = new System.Drawing.Point(354, 307);
            this.btnAlterarNome.Name = "btnAlterarNome";
            this.btnAlterarNome.Size = new System.Drawing.Size(112, 32);
            this.btnAlterarNome.TabIndex = 6;
            this.btnAlterarNome.Text = "Alterar Nome";
            this.btnAlterarNome.UseVisualStyleBackColor = true;
            this.btnAlterarNome.Click += new System.EventHandler(this.btnAlterarNome_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(354, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 43);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(232, 355);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(116, 43);
            this.btnTodos.TabIndex = 8;
            this.btnTodos.Text = "Excluir Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total de Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alterar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(159, 385);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Curso";
            // 
            // btnAlterarCurso
            // 
            this.btnAlterarCurso.Location = new System.Drawing.Point(354, 345);
            this.btnAlterarCurso.Name = "btnAlterarCurso";
            this.btnAlterarCurso.Size = new System.Drawing.Size(112, 33);
            this.btnAlterarCurso.TabIndex = 14;
            this.btnAlterarCurso.Text = "Alterar Curso";
            this.btnAlterarCurso.UseVisualStyleBackColor = true;
            this.btnAlterarCurso.Click += new System.EventHandler(this.btnAlterarCurso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.btnAlterarCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterarNome);
            this.Controls.Add(this.dgvalunos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.MaskedTextBox txtAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView dgvalunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.Button btnAlterarNome;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterarCurso;
    }
}

