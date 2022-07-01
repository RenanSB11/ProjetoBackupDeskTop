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
    class clVendaItem
    {
        public int idvenda_item;
        public int idvenda;
        public int idproduto;
        public decimal valor;
        public int qtde;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO venda_item ( idvenda, idproduto, valor, qtde ) " +
                                              " values ({0},{1},'{2}',{3} )",
                                                idvenda, idproduto, valor, qtde) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Item de Venda cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Item de Venda", "Erro", MessageBoxButtons.OK,
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
    }
}