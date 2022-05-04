namespace Aula63_Exe2
{
    partial class CriarLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.btnGerarLocacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAvista = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.rdbBoleto = new System.Windows.Forms.RadioButton();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbCliente = new System.Windows.Forms.ComboBox();
            this.ckbproduto = new System.Windows.Forms.ComboBox();
            this.lblChavePix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(24, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(24, 82);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(24, 132);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.Location = new System.Drawing.Point(24, 174);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(56, 20);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses";
            // 
            // btnGerarLocacao
            // 
            this.btnGerarLocacao.Location = new System.Drawing.Point(453, 23);
            this.btnGerarLocacao.Name = "btnGerarLocacao";
            this.btnGerarLocacao.Size = new System.Drawing.Size(175, 98);
            this.btnGerarLocacao.TabIndex = 6;
            this.btnGerarLocacao.Text = "Gerar Locação";
            this.btnGerarLocacao.UseVisualStyleBackColor = true;
            this.btnGerarLocacao.Click += new System.EventHandler(this.btnGerarLocacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione a Forma de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sua Locação ficou no Total de:";
            // 
            // rdbAvista
            // 
            this.rdbAvista.AutoSize = true;
            this.rdbAvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAvista.Location = new System.Drawing.Point(16, 269);
            this.rdbAvista.Name = "rdbAvista";
            this.rdbAvista.Size = new System.Drawing.Size(78, 24);
            this.rdbAvista.TabIndex = 8;
            this.rdbAvista.TabStop = true;
            this.rdbAvista.Text = "A Vista";
            this.rdbAvista.UseVisualStyleBackColor = true;
            this.rdbAvista.CheckedChanged += new System.EventHandler(this.rdbAvista_CheckedChanged);
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPix.Location = new System.Drawing.Point(16, 299);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(53, 24);
            this.rdbPix.TabIndex = 8;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "PIX";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.CheckedChanged += new System.EventHandler(this.rdbPix_CheckedChanged);
            // 
            // rdbBoleto
            // 
            this.rdbBoleto.AutoSize = true;
            this.rdbBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBoleto.Location = new System.Drawing.Point(16, 332);
            this.rdbBoleto.Name = "rdbBoleto";
            this.rdbBoleto.Size = new System.Drawing.Size(73, 24);
            this.rdbBoleto.TabIndex = 8;
            this.rdbBoleto.TabStop = true;
            this.rdbBoleto.Text = "Boleto";
            this.rdbBoleto.UseVisualStyleBackColor = true;
            this.rdbBoleto.CheckedChanged += new System.EventHandler(this.rdbBoleto_CheckedChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(246, 386);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(21, 13);
            this.lbltotal.TabIndex = 9;
            this.lbltotal.Text = "R$";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(187, 131);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(212, 20);
            this.txtValor.TabIndex = 11;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(187, 174);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(212, 20);
            this.txtMeses.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula63_Exe2.Properties.Resources._cloud_confirm_86838;
            this.pictureBox1.Location = new System.Drawing.Point(648, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ckbCliente
            // 
            this.ckbCliente.FormattingEnabled = true;
            this.ckbCliente.Location = new System.Drawing.Point(182, 35);
            this.ckbCliente.Name = "ckbCliente";
            this.ckbCliente.Size = new System.Drawing.Size(216, 21);
            this.ckbCliente.TabIndex = 12;
            // 
            // ckbproduto
            // 
            this.ckbproduto.FormattingEnabled = true;
            this.ckbproduto.Location = new System.Drawing.Point(182, 81);
            this.ckbproduto.Name = "ckbproduto";
            this.ckbproduto.Size = new System.Drawing.Size(216, 21);
            this.ckbproduto.TabIndex = 12;
            this.ckbproduto.SelectedIndexChanged += new System.EventHandler(this.ckbproduto_SelectedIndexChanged);
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.Location = new System.Drawing.Point(91, 306);
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(0, 13);
            this.lblChavePix.TabIndex = 13;
            // 
            // CriarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChavePix);
            this.Controls.Add(this.ckbproduto);
            this.Controls.Add(this.ckbCliente);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.rdbBoleto);
            this.Controls.Add(this.rdbPix);
            this.Controls.Add(this.rdbAvista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarLocacao);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.Name = "CriarLocacao";
            this.Text = "CriarLocacao";
            this.Load += new System.EventHandler(this.CriarLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Button btnGerarLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAvista;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.RadioButton rdbBoleto;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.ComboBox ckbCliente;
        private System.Windows.Forms.ComboBox ckbproduto;
        private System.Windows.Forms.Label lblChavePix;
    }
}