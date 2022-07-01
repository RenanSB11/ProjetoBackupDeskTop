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
    public partial class frmBuscaProduto : Form
    {
        public frmBuscaProduto()
        {
            InitializeComponent();
        }

        public clEstoque produto  = new clEstoque();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                //dgvProduto.Columns[0].Visible = false;
                //dgvProduto.Columns[3].Visible = false;

                //dgvProduto.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void frmBuscaProduto_Load(object sender, EventArgs e)
        {
            txtPesquisa_TextChanged(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
        }
    }
}
