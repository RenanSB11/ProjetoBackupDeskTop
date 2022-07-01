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
    public partial class frmGerencia : Form
    {
        public frmGerencia()
        {
            InitializeComponent();
        }

        private void frmGerencia_Shown(object sender, EventArgs e)
        {
            frmLogin formulario = new frmLogin();
            formulario.ShowDialog();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void tsmPedidos_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void tsmEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque formulario = new frmEstoque();
            formulario.ShowDialog();
        }

        private void tsmFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor formulario = new frmFornecedor();
            formulario.ShowDialog();
        }

        private void tsmFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios formulario = new frmFuncionarios();
            formulario.ShowDialog();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
        }
    }
}
