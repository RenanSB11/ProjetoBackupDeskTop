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
    public partial class frmCadastraFornecedor : Form
    {
        public frmCadastraFornecedor()
        {
            InitializeComponent();
        }

        public clFornecedor fornecedor;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCNPJ.Text != "" && txtNome.Text != "" && txtTelefone.Text != "" && txtContato.Text != "") 
            {
                clFornecedor fornecedor = new clFornecedor();
                fornecedor.nome = txtNome.Text;
                fornecedor.cnpj = txtCNPJ.Text;
                fornecedor.telefone = txtTelefone.Text;
                fornecedor.contato = txtContato.Text;

                if (txtID.Text == "")
                {
                    txtID.Text = Convert.ToString(fornecedor.Salvar());
                }
                else
                {
                    fornecedor.idfornecedor = int.Parse(txtID.Text);
                    fornecedor.Atualizar();
                }
            }
            else
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome não preenchido!");
                }
                if (txtContato.Text == "")
                {
                    MessageBox.Show("Contato não preenchido!");
                }
                if (txtCNPJ.Text == "")
                {
                    MessageBox.Show("CNPJ não preenchido!");
                }
                if (txtTelefone.Text == "")
                {
                    MessageBox.Show("Telefone não preenchida!");
                }
            }
        }

        private void frmCadastraFornecedor_Load(object sender, EventArgs e)
        {
            if (fornecedor != null)
            {
                txtCNPJ.Text = fornecedor.cnpj;
                txtContato.Text = fornecedor.contato;
                txtNome.Text = fornecedor.nome;
                txtTelefone.Text = fornecedor.telefone;
                btnSalvar.Text = "Atualizar";
            }
        }
    }
}
