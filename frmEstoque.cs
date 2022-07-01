using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBackupDeskTop
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        public clEstoque Estoque = new clEstoque();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastraProdutos formulario = new frmCadastraProdutos();
            formulario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvEstoque.SelectedRows;
                Estoque.cod_produto = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o produto " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    Estoque.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um produto para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    Estoque.nome_produto = txtPesquisa.Text;
                    dgvEstoque.DataSource = Estoque.PesquisaPorNome();
                }

            //    dgvEstoque.Columns[0].Visible = false;
            //    dgvEstoque.Columns[5].Visible = false;
            //    dgvEstoque.Columns[6].Visible = false;

                dgvEstoque.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvEstoque.SelectedRows;
                Estoque.cod_produto = int.Parse(linha[0].Cells[0].Value.ToString());
                Estoque.cod_fornecedor = int.Parse(linha[0].Cells[1].Value.ToString());
                Estoque.validade = DateTime.Parse(linha[0].Cells[4].Value.ToString());
                Estoque.nome_produto = linha[0].Cells[5].Value.ToString();
                Estoque.preco = decimal.Parse(linha[0].Cells[2].Value.ToString());
                Estoque.quantidade = int.Parse(linha[0].Cells[3].Value.ToString());

                frmCadastraProdutos formulario = new frmCadastraProdutos();
                formulario.produto = Estoque;
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }  
            private void frmEstoque_Load(object sender, EventArgs e)
             {

             }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
