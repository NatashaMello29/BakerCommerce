using BakerCommerce.Model;
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
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;

        int IdSelecionado = 0;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriasCmb();
            AtualizarDgv();
        }

        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela para receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Validar campos:
            if (txbNomeCadastrar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastrar.Text == "")
            {
                MessageBox.Show("O Preço deve ter no mínimo 1 caracteres",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Categoria!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer cadastro...
                Model.Produto produtoCadastro = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoCadastro.Nome = txbNomeCadastrar.Text;
                produtoCadastro.Preco = double.Parse(txbPrecoCadastrar.Text);
                produtoCadastro.IdRespCadastro = usuario.Id;
                string[] categoriaArray = cmbCategoriaCadastro.Text.Split('-');
                string idCategoria = categoriaArray[0]; // Pega apenas o ID (primeira parte)
                produtoCadastro.idCategoria = int.Parse(idCategoria);
                // Executar o INSERT:
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    AtualizarDgv();



                    // Apagar os campos de cadastro:
                    txbNomeCadastrar.Clear();
                    txbPrecoCadastrar.Clear();
                    cmbCategoriaCadastro.ResetText();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o produto.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();
        }

        private void btnCadastrarEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 2)
            {
                MessageBox.Show("O nome deve ter no mínimo 2 caracteres",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text == "")
            {
                MessageBox.Show("O Preço deve ter no mínimo 1 caracteres",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaEditar.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Categoria!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir com a edição:
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;
                produtoEditar.Id = IdSelecionado;
                string[] categoriaArray = cmbCategoriaEditar.Text.Split('-');
                string idCategoria = categoriaArray[0]; // Pega apenas o ID (primeira parte)
                produtoEditar.idCategoria = int.Parse(idCategoria);


                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Produto modificado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar Produto!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        public void ResetarCampos()
        {
            //Atualizar o dvg:
            AtualizarDgv();

            //Limpar campos de edição:
            txbNomeEditar.Clear();
            txbPrecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = -1;

            // Retornar o idSelecionado para 0
            IdSelecionado = 0;

            //Retornar o texto padrão do "apagar":
            lblApagar.Text = "Selecione o usuário que deseja apagar.";

            // Desabilitar os grbs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;

            // Colocar os valores das células dos txB de edição:
            txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
            IdSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;

            // Ativar o grbEditar:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Ajustes no grbApagar:
            lblApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value}";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse produto?",
               "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a Exclusão...
                Model.Produto produtoApagar = new Model.Produto();

                produtoApagar.Id = IdSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show!",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o Produto.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}