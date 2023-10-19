namespace Menssagens
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.btnExemplo1 = new System.Windows.Forms.Button();
            this.btnExemplo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mensagem1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 114);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mensagem2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 124);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mensagem3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(73, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 114);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mensagem4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(73, 550);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 128);
            this.button5.TabIndex = 4;
            this.button5.Text = "Mensagem5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Solução";
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(348, 306);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(416, 20);
            this.txtSelecao.TabIndex = 8;
            // 
            // btnExemplo1
            // 
            this.btnExemplo1.Location = new System.Drawing.Point(348, 355);
            this.btnExemplo1.Name = "btnExemplo1";
            this.btnExemplo1.Size = new System.Drawing.Size(176, 74);
            this.btnExemplo1.TabIndex = 9;
            this.btnExemplo1.Text = "Exemplo 1";
            this.btnExemplo1.UseVisualStyleBackColor = true;
            this.btnExemplo1.Click += new System.EventHandler(this.btnExemplo1_Click);
            // 
            // btnExemplo2
            // 
            this.btnExemplo2.Location = new System.Drawing.Point(588, 355);
            this.btnExemplo2.Name = "btnExemplo2";
            this.btnExemplo2.Size = new System.Drawing.Size(176, 74);
            this.btnExemplo2.TabIndex = 10;
            this.btnExemplo2.Text = "Exemplo 2";
            this.btnExemplo2.UseVisualStyleBackColor = true;
            this.btnExemplo2.Click += new System.EventHandler(this.btnExemplo2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 716);
            this.Controls.Add(this.btnExemplo2);
            this.Controls.Add(this.btnExemplo1);
            this.Controls.Add(this.txtSelecao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Button btnExemplo1;
        private System.Windows.Forms.Button btnExemplo2;
    }
}

