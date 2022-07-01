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
    public partial class frmFuncionarios : Form
    {

        public frmFuncionarios()
        {
            InitializeComponent();
        }

        clFuncionario Funcionario = new clFuncionario();

        private void btnAtualizar_Load(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFuncionario.SelectedRows;
                Funcionario.idfuncionario = int.Parse(linha[0].Cells[0].Value.ToString());
                Funcionario.escala = linha[0].Cells[1].Value.ToString();
                Funcionario.funcao = linha[0].Cells[2].Value.ToString();
                Funcionario.nome = linha[0].Cells[3].Value.ToString();
                Funcionario.login = linha[0].Cells[4].Value.ToString();
                Funcionario.senha = linha[0].Cells[5].Value.ToString();

                frmCadastraFuncionario formulario = new frmCadastraFuncionario();
                formulario.Funcionario = Funcionario;
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFuncionario.SelectedRows;
                Funcionario.idfuncionario = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o funcionario " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um funcionario para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    Funcionario.nome = txtPesquisa.Text;
                    dgvFuncionario.DataSource = Funcionario.PesquisaPorNome();
                }

               // dgvFuncionario.Columns[0].Visible = false;
               // dgvFuncionario.Columns[1].Visible = false;
               // dgvFuncionario.Columns[2].Visible = false;
               // dgvFuncionario.Columns[3].Visible = false;

                dgvFuncionario.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastraFuncionario formulario = new frmCadastraFuncionario();
            formulario.ShowDialog();
        }
    }
}
