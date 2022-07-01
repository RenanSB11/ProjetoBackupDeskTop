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
    public partial class frmInfoMesa : Form
    {
        public frmInfoMesa()
        {
            InitializeComponent();
        }

        public int idproduto;
        public int idMesa;
        clEstoque estoque  = new clEstoque();
        clVenda venda = new clVenda();
        



        private void button3_Click(object sender, EventArgs e)
        {
            decimal valortotal = 0;
            valortotal = decimal.Parse(txtValor.Text) * nudQtde.Value;
            dgvProdutos.Rows.Add(lblId.Text, txtProduto.Text, nudQtde.Text, valortotal.ToString());
            txtProduto.Text = "";
            txtValor.Text = "";
            nudQtde.Value = 1;
            lblResultado.Text = Convert.ToString(Convert.ToDecimal(lblResultado.Text) + valortotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            clVenda venda = new clVenda();

            venda.data = DateTime.Now;
            venda.valor = decimal.Parse(lblResultado.Text);
            lblidVenda.Text = Convert.ToString(venda.Salvar());

            clVendaItem item = new clVendaItem();

            for (int c = 0; c < dgvProdutos.Rows.Count; c++)
            {
                item.idvenda = int.Parse(lblidVenda.Text);
                item.idproduto = int.Parse(dgvProdutos.Rows[c].Cells[0].Value.ToString());
                item.qtde = int.Parse(dgvProdutos.Rows[c].Cells[2].Value.ToString());
                item.valor = decimal.Parse(dgvProdutos.Rows[c].Cells[3].Value.ToString());
                item.Salvar();// Salva a venda

            }

            this.Close();
        }

        private void nudQtde_ValueChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
                lblTotal.Text = "Total: R$ " + Convert.ToString(decimal.Parse(txtValor.Text) * nudQtde.Value);
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            frmEstoque  BuscaProduto = new frmEstoque();
            this.Hide();
            BuscaProduto.ShowDialog();
            estoque.cod_produto = BuscaProduto.Estoque.cod_produto;
            this.Show();

            if (estoque.cod_produto != 0)
            {
                DataTable dtProduto = estoque.PesquisaPorNome();
                decimal valor = decimal.Parse(dtProduto.Rows[0]["valor"].ToString());
                txtProduto.Text = dtProduto.Rows[0]["nome"].ToString();
                txtValor.Text = decimal.Round(valor, 2).ToString();
                nudQtde.Maximum = int.Parse(dtProduto.Rows[0]["qtde"].ToString());
                lblTotal.Text = "Total: R$ " + Convert.ToString(decimal.Round(valor, 2) * nudQtde.Value);
                lblId.Text = estoque.cod_produto.ToString();

                if (dtProduto != null)
                {
                    if (dtProduto.Rows.Count > 0)
                    {
                        txtProduto.Text = dtProduto.Rows[0]["id"].ToString();
                        txtProduto.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                MessageBox.Show("preencha o id do produto!", "Campo em branco!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduto.Focus();
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmInfoMesa formulario = new frmInfoMesa();
            formulario.ShowDialog();
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            

            
