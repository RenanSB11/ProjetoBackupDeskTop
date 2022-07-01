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
    public partial class frmCadastraFuncionario : Form
    {
        public frmCadastraFuncionario()
        {
            InitializeComponent();
        }

        public clFuncionario Funcionario = new clFuncionario();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtEscala.Text != "" && txtNome.Text != "" && txtLogin.Text != "" && txtFuncao.Text != "")
            {
                
                Funcionario.nome = txtNome.Text;
                Funcionario.escala = txtEscala.Text;
                Funcionario.funcao = txtFuncao.Text;
                Funcionario.login = txtLogin.Text;
                Funcionario.senha = txtSenha.Text;

                if (txtID.Text == "")
                {
                    txtID.Text = Convert.ToString(Funcionario.Salvar());
                }
                else
                {
                    Funcionario.idfuncionario = int.Parse(txtID.Text);
                    Funcionario.Atualizar();
                }
            }
            else
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome não preenchido!");
                }
                if (txtFuncao.Text == "")
                {
                    MessageBox.Show("Função não preenchido!");
                }
                if (txtEscala.Text == "")
                {
                    MessageBox.Show("Escala não preenchido!");
                }
                if (txtLogin.Text == "")
                {
                    MessageBox.Show("Login não preenchida!");
                }
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Senha não preenchida!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraFuncionario_Load(object sender, EventArgs e)
        {
            if (Funcionario != null)
            {
                txtEscala.Text = Funcionario.escala;
                txtFuncao.Text = Funcionario.funcao;
                txtNome.Text = Funcionario.nome;
                txtLogin.Text = Funcionario.login;
                txtSenha.Text = Funcionario.senha;
                btnSalvar.Text = "Salvar";
            }
        }
    }
}
