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
    class clVenda
    {
        public int idvenda;
        public int idcliente;
        public decimal valor;
        public DateTime data;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO venda ( idcliente, valor, data ) " +
                                              " values ({0},'{1}','{2}' )",
                                                idcliente, valor, data.ToShortDateString()) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Venda cadastrada com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Venda", "Erro", MessageBoxButtons.OK,
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
