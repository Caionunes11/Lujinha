using System;
using System.Windows.Forms;

namespace Lujinha.WF
{
    public partial class FormVendas : Form
    {

        double valorSomaTotal = 0;
        public FormVendas()
        {
            InitializeComponent();
        }


        private void btnLimparProdutos_Click(object sender, EventArgs e)
        {

            LimpaCampos();
        }


        public void LimpaCampos()
        {
            listProduto.SelectedIndex = -1;
            listValorUnitario.SelectedIndex = -1;
            listQuantidadeItens.SelectedIndex = -1;
            txtOutrasQuantidadesPecas.Clear();
            txtOutroValorUnitario.Clear();
            txtProdutosOutros.Clear();
        }

        private void listProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduto.SelectedIndex != -1)
            {
                txtProdutosOutros.Clear();
                txtProdutosOutros.Enabled = false;
            }
            else
            {
                txtProdutosOutros.Clear();
                txtProdutosOutros.Enabled = true;
            }
        }

        private void listValorUnitario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listValorUnitario.SelectedIndex != -1)
            {
                txtOutroValorUnitario.Clear();
                txtOutroValorUnitario.Enabled = false;
            }
            else
            {
                txtOutroValorUnitario.Clear();
                txtOutroValorUnitario.Enabled = true;
            }

        }

        private void listQuantidadeItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQuantidadeItens.SelectedIndex != -1)
            {
                txtOutrasQuantidadesPecas.Clear();
                txtOutrasQuantidadesPecas.Enabled = false;
            }
            else
            {
                txtOutrasQuantidadesPecas.Clear();
                txtOutrasQuantidadesPecas.Enabled = true;
            }
        }

        private void btnAdicionarProdutos_Click(object sender, EventArgs e)
        {
            string produtoSelecionado = listProduto.SelectedIndex != -1 ? listProduto.SelectedItem.ToString() : txtProdutosOutros.ToString();
            var valorUnitario = listValorUnitario.SelectedIndex != -1 ? listValorUnitario.SelectedItem.ToString() : txtOutroValorUnitario.ToString();
            var quantidadeProdutos = listQuantidadeItens.SelectedIndex != -1 ? listQuantidadeItens.SelectedItem.ToString() : txtOutrasQuantidadesPecas.ToString();

            var valorUnitarioConvertidoString = valorUnitario.Replace(" R$", "");
           
            var valorUnitarioConvertidoValor = Convert.ToInt32(valorUnitarioConvertidoString);
            var quantidadeUnitariaConvertida = Convert.ToInt32(quantidadeProdutos);


            listResumoPedido.Items.Add(produtoSelecionado + "             " + valorUnitario + "               " + quantidadeProdutos);
            listResumoValorTotal.Items.Add(valorUnitarioConvertidoValor * quantidadeUnitariaConvertida + " R$");

            valorSomaTotal = valorSomaTotal + valorUnitarioConvertidoValor * quantidadeUnitariaConvertida;
            labelValorTotal.Text = Convert.ToString(valorSomaTotal + " R$");




            LimpaCampos();
        }

    }
}
