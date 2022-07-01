
namespace ProjetoBackupDeskTop
{
    partial class frmCadastraProdutos
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod_Produto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(303, 153);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(222, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Validade:";
            // 
            // txtVal
            // 
            this.txtVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVal.Location = new System.Drawing.Point(12, 117);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(141, 20);
            this.txtVal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cod_Fornecedor";
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodFornecedor.Location = new System.Drawing.Point(208, 25);
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodFornecedor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtd.Location = new System.Drawing.Point(208, 67);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(170, 20);
            this.txtQtd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.Location = new System.Drawing.Point(12, 67);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(141, 20);
            this.txtPreco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cod_Produto";
            // 
            // txtCod_Produto
            // 
            this.txtCod_Produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod_Produto.Enabled = false;
            this.txtCod_Produto.Location = new System.Drawing.Point(14, 25);
            this.txtCod_Produto.Name = "txtCod_Produto";
            this.txtCod_Produto.Size = new System.Drawing.Size(79, 20);
            this.txtCod_Produto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nome:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(208, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 6;
            // 
            // frmCadastraProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 187);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCod_Produto);
            this.Name = "frmCadastraProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastraProdutos";
            this.Load += new System.EventHandler(this.frmCadastraProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod_Produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
    }
}