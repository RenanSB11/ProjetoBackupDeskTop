using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
namespace ProjetoBackupDeskTop
{
    public class clFuncionario
    {
        // atributos
        public int idfuncionario;
        public string login;
        public string senha;
        public string escala;
        public string funcao;
        public string nome;

        conectaBD BD = new conectaBD();

        public DataTable EfetuarLogin()
        {
            try
            {
                BD._sql = "SELECT * FROM FUNCIONARIO " +
                         " WHERE LOGIN LIKE '" + login + "' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM FUNCIONARIO " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Excluir()
        {
            try
            {
                int exOK = 0;

                BD._sql = "DELETE FROM FUNCIONARIO WHERE ID_FUNCIONARIO = " + idfuncionario;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Funcionario deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FUNCIONARIO ( NOME, FUNÇÃO, ESCALA, LOGIN, SENHA) " +
                                              " values ('{0}','{1}','{2}','{3}','{4}' )",
                                                nome, funcao, escala, login, senha) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionario", "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            return id;
        }

        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE PRODUTO SET NOME = '" + nome + "', ESCALA = '" + escala + "', FUNÇÂO = '" + funcao + "', LOGIN = '" + login + "', SENHA = '" + senha +
               "' where ID_FUNCIONARIO = " + idfuncionario;

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Funcionario Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Funcionario, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //return id_cliente;
                //return BD.ExecutaComando(false, out id_funcionario);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}