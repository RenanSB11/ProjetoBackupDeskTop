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
    public class clFornecedor
    {
        public int idfornecedor;
        public string nome;
        public string cnpj;
        public string telefone;
        public string contato;

        conectaBD BD = new conectaBD();

        // métodos
        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FORNECEDOR ( NOME, CNPJ, TELEFONE, CONTATO) " +
                                              " values ('{0}','{1}','{2}','{3}' )",
                                                nome, cnpj, telefone, contato) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Fornecedor", "Erro", MessageBoxButtons.OK,
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

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM FORNECEDOR " +
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

                BD._sql = "DELETE FROM FORNECEDOR WHERE COD_FORNECEDOR = " + idfornecedor;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Fornecedor deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE PRODUTO SET NOME = '" + nome + "', CNPJ = '" + cnpj + "', CONTATO = '" + contato + "', TELEFONE = '" + telefone +
               "' where ID_FORNECEDOR = " + idfornecedor;

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Cliente Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Cliente, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
