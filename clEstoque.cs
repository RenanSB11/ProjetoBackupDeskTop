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
    public class clEstoque
    {
        public int cod_produto;
        public int cod_fornecedor;
        public int quantidade;
        public decimal preco;
        public DateTime validade;
        public string nome_produto;

        conectaBD BD = new conectaBD();

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM PRODUTO " +
                         " WHERE NOME_PRODUTO LIKE '%" + nome_produto + "%' ";

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

                BD._sql = "DELETE FROM PRODUTO WHERE COD_PRODUTO = " + cod_produto;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Produto deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO ( NOME_produto, COD_FORNECEDOR, VALIDADE, QUANTIDADE, preco) " +
                                              " values ('{0}','{1}','{2}','{3}','{4}' )",
                                                nome_produto, cod_fornecedor, validade, quantidade, preco.ToString().Replace(",", ".")) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Erro", MessageBoxButtons.OK,
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

                BD._sql = "UPDATE PRODUTO SET NOME_PRODUTO = '" + nome_produto + "', PRECO = '" + preco.ToString().Replace(",", ".") + "', QUANTIDADE = '" + quantidade + "', VALIDADE = '" + validade +
               "' where COD_PRODUTO = " + cod_produto;

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Produto Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Produto, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
