
namespace ProjetoBackupDeskTop
{
    partial class frmInfoMesa
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
            this.lblidVenda = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudQtde = new System.Windows.Forms.NumericUpDown();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidVenda
            // 
            this.lblidVenda.AutoSize = true;
            this.lblidVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidVenda.Location = new System.Drawing.Point(582, 476);
            this.lblidVenda.Name = "lblidVenda";
            this.lblidVenda.Size = new System.Drawing.Size(0, 33);
            this.lblidVenda.TabIndex = 45;
            this.lblidVenda.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(426, 476);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(31, 33);
            this.lblResultado.TabIndex = 44;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.dgvProdutos);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 451);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(380, 192);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Lista de Compras";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nmProduto,
            this.QTD,
            this.TOTAL});
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 25);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(368, 161);
            this.dgvProdutos.TabIndex = 28;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id_produto";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 95;
            // 
            // nmProduto
            // 
            this.nmProduto.HeaderText = "PRODUTO";
            this.nmProduto.Name = "nmProduto";
            this.nmProduto.ReadOnly = true;
            this.nmProduto.Width = 200;
            // 
            // QTD
            // 
            this.QTD.HeaderText = "QTD";
            this.QTD.Name = "QTD";
            this.QTD.ReadOnly = true;
            this.QTD.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 95;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(653, 166);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mesa";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(127, 89);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 48);
            this.button12.TabIndex = 8;
            this.button12.Text = "Mesa 6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(208, 89);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 48);
            this.button11.TabIndex = 7;
            this.button11.Text = "Mesa 7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(289, 89);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 48);
            this.button10.TabIndex = 6;
            this.button10.Text = "Mesa 8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(370, 89);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 48);
            this.button9.TabIndex = 5;
            this.button9.Text = "Mesa 9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(451, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 48);
            this.button8.TabIndex = 4;
            this.button8.Text = "Mesa 5";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(370, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 48);
            this.button7.TabIndex = 3;
            this.button7.Text = "Mesa 4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(289, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 48);
            this.button6.TabIndex = 2;
            this.button6.Text = "Mesa 3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(208, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 48);
            this.button5.TabIndex = 1;
            this.button5.Text = "Mesa 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 0;
            this.button4.Text = "Mesa 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(398, 551);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 92);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Concluir";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Concluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.bntSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 261);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nudQtde);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProduto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(10, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 143);
            this.panel2.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(406, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 40;
            this.lblId.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 34);
            this.button3.TabIndex = 39;
            this.button3.Text = "Adicionar Produto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(7, 106);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(347, 31);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total: R$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Quant.";
            // 
            // nudQtde
            // 
            this.nudQtde.Location = new System.Drawing.Point(245, 39);
            this.nudQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtde.Name = "nudQtde";
            this.nudQtde.Size = new System.Drawing.Size(64, 26);
            this.nudQtde.TabIndex = 7;
            this.nudQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtde.ValueChanged += new System.EventHandler(this.nudQtde_ValueChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(104, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(72, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor Un. R$";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(74, 7);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(560, 26);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Produto";
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(416, 16);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(228, 34);
            this.bntSearch.TabIndex = 4;
            this.bntSearch.Text = "Buscar Produto";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // frmInfoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 658);
            this.Controls.Add(this.lblidVenda);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInfoMesa";
            this.Text = "InfoMesa";
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidVenda;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudQtde;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}