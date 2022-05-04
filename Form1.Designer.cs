namespace Aula63_Exe2
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
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCriarLocacao = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(159, 192);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(150, 100);
            this.btnProduto.TabIndex = 0;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCriarLocacao
            // 
            this.btnCriarLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarLocacao.Location = new System.Drawing.Point(159, 321);
            this.btnCriarLocacao.Name = "btnCriarLocacao";
            this.btnCriarLocacao.Size = new System.Drawing.Size(150, 100);
            this.btnCriarLocacao.TabIndex = 0;
            this.btnCriarLocacao.Text = "Criar Locação";
            this.btnCriarLocacao.UseVisualStyleBackColor = true;
            this.btnCriarLocacao.Click += new System.EventHandler(this.btnCriarLocacao_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(159, 63);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(150, 100);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 500);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCriarLocacao);
            this.Controls.Add(this.btnProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCriarLocacao;
        private System.Windows.Forms.Button btnCliente;
    }
}

