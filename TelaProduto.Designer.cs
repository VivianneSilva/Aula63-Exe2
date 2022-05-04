namespace Aula63_Exe2
{
    partial class TelaProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDproduto = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCarac = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxProduto = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caracteristicas";
            // 
            // txtIDproduto
            // 
            this.txtIDproduto.Location = new System.Drawing.Point(207, 66);
            this.txtIDproduto.Name = "txtIDproduto";
            this.txtIDproduto.Size = new System.Drawing.Size(270, 20);
            this.txtIDproduto.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(207, 101);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(270, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // txtCarac
            // 
            this.txtCarac.Location = new System.Drawing.Point(207, 141);
            this.txtCarac.Name = "txtCarac";
            this.txtCarac.Size = new System.Drawing.Size(270, 20);
            this.txtCarac.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(558, 66);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 85);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(46, 252);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(120, 69);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula63_Exe2.Properties.Resources._1486504328_bullet_list_menu_lines_points_items_options_81334;
            this.pictureBox1.Location = new System.Drawing.Point(884, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 126);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxProduto
            // 
            this.listBoxProduto.FormattingEnabled = true;
            this.listBoxProduto.Location = new System.Drawing.Point(46, 331);
            this.listBoxProduto.Name = "listBoxProduto";
            this.listBoxProduto.Size = new System.Drawing.Size(280, 251);
            this.listBoxProduto.TabIndex = 4;
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 594);
            this.Controls.Add(this.listBoxProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCarac);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtIDproduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaProduto";
            this.Text = "TelaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDproduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCarac;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxProduto;
    }
}