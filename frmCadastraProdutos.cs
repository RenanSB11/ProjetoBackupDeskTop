using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoBackupDeskTop
{
    public partial class frmCadastraProdutos : Form
    {
        public frmCadastraProdutos()
        {
            InitializeComponent();
        }

        public clEstoque produto;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtPreco.Text != "" && txtQtd.Text != "" && txtCodFornecedor.Text != "" && txtVal.Text != "")
            {
                clEstoque produto = new clEstoque();
                produto.nome_produto = txtNome.Text;
                produto.preco = Convert.ToDecimal(txtPreco.Text);
                produto.quantidade = Convert.ToInt32(txtQtd.Text);
                produto.cod_fornecedor = Convert.ToInt32(txtCodFornecedor.Text);
                produto.validade = Convert.ToDateTime(txtVal.Text);

                if (txtCod_Produto.Text == "")
                {
                    txtCod_Produto.Text = Convert.ToString(produto.Salvar());
                }
                else
                {
                    produto.cod_produto = int.Parse(txtCod_Produto.Text);
                    produto.Atualizar();
                }

                this.Close();
            }
            else
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome não preenchido!");
                }
                if (txtCodFornecedor.Text == "")
                {
                    MessageBox.Show("Fornecedor não preenchido!");
                }
                if (txtPreco.Text == "")
                {
                    MessageBox.Show("Preço não preenchido!");
                }
                if (txtQtd.Text == "")
                {
                    MessageBox.Show("Quantidade não preenchida!");
                }
                if (txtVal.Text == "")
                {
                    MessageBox.Show("Validade não preenchida!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraProdutos_Load(object sender, EventArgs e)
        {
            if (produto != null)
            {
                txtCod_Produto.Text = produto.cod_produto.ToString();
                txtNome.Text = produto.nome_produto;
                txtPreco.Text = produto.preco.ToString().Substring(0,produto.preco.ToString().Length-2);
                txtQtd.Text = produto.quantidade.ToString();
                txtVal.Text = produto.validade.ToString();
                txtCodFornecedor.Text = produto.cod_fornecedor.ToString();
                btnSalvar.Text = "Atualizar";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
