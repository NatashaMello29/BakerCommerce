using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormComandas : Form
    {
        Model.Usuario Usuario;
        public FormComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvComandas.DataSource = produto.Listar();
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvComandas.SelectedCells[0].RowIndex;

            // Colocar o Id do produto no campo de código:
            txbCodProduto.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();
            // Colocar o nome do produto no campo de informações:
            txbProduto.Text = dgvComandas.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnContinuarComanda_Click(object sender, EventArgs e)
        {
            if(txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txbCodProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Desativar o grbInfos:
                grbInformacoesComandas.Enabled = false;
                // Ativar o grbLancamento:
                grbLancamentoComanda.Enabled = true;
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            //Verificar se a quantidade foi preenchida:
            if(txbQuantidade.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade!", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbCodProduto.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                ordemComanda.IdResp = Usuario.Id;

                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetarCampos()
        {
            // Limpar os txbs:
            txbCodProduto.Clear();
            txbQuantidade.Clear();
            txbProduto.Clear();
            txbComanda.Clear();
            // Resetar os groupBoxes:
            grbLancamentoComanda.Enabled = false;
            grbInformacoesComandas.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
