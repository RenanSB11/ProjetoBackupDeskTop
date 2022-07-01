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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        clFornecedor Fornecedor = new clFornecedor();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
                Fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o fornecedor " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    Fornecedor.Excluir();
                    txtBusca_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um fornecedor para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBusca.Text != "")
                {
                    Fornecedor.nome = txtBusca.Text;
                    dgvFornecedor.DataSource = Fornecedor.PesquisaPorNome();
                }

              //  dgvFornecedor.Columns[0].Visible = false;
              //  dgvFornecedor.Columns[5].Visible = false;
              //  dgvFornecedor.Columns[6].Visible = false;

                dgvFornecedor.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
                Fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());
                Fornecedor.cnpj = linha[0].Cells[1].Value.ToString();
                Fornecedor.telefone = linha[0].Cells[2].Value.ToString();
                Fornecedor.nome = linha[0].Cells[3].Value.ToString();
                Fornecedor.contato = linha[0].Cells[4].Value.ToString();

                frmCadastraFornecedor formulario = new frmCadastraFornecedor();
                formulario.fornecedor = Fornecedor;
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastraFornecedor formulario = new frmCadastraFornecedor();
            formulario.ShowDialog();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
