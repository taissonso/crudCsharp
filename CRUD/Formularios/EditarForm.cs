using CRUD.Funções;
using CRUD.Intermedio;
using CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Formularios
{
    public partial class EditarForm : Form
    {
        public EditarForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            listar();
            
        }

        private void listar()
        {
            clienteSAVE mostrar = new clienteSAVE();

            gridMostrar.DataSource = mostrar.listar();

            gridMostrar.Columns[0].Visible = false;
            gridMostrar.Columns[1].HeaderText = "CPF/CNPJ";
            gridMostrar.Columns[2].HeaderText = "Nome";
            gridMostrar.Columns[3].HeaderText = "Rua";
            gridMostrar.Columns[4].HeaderText = "Número";
            gridMostrar.Columns[5].HeaderText = "Cidade";
            gridMostrar.Columns[6].HeaderText = "Pedido";
            gridMostrar.Columns[7].HeaderText = "Código";
            gridMostrar.Columns[8].HeaderText = "Quantidade";
            gridMostrar.Columns[9].HeaderText = "Valor";
            gridMostrar.Columns[10].HeaderText = "Descrição";

            gridMostrar.Columns[1].Width = 75;
            gridMostrar.Columns[2].Width = 150;
            gridMostrar.Columns[3].Width = 100;
            gridMostrar.Columns[4].Width = 50;
        }

        private void editar(Cliente cliente)
        {
            cadastro clienteEditar = new cadastro();

            if (
                txtNome.Text.Trim() == string.Empty || txtCpf.Text.Trim() == string.Empty ||
                txtRua.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty ||
                txtCidade.Text.Trim() == string.Empty || txtPedido.Text.Trim() == string.Empty ||
                txtCodigo.Text.Trim() == string.Empty || txtQuantidade.Text.Trim() == string.Empty ||
                txtValor.Text.Trim() == string.Empty || txtDescricao.Text.Trim() == string.Empty
                )
            {
                MessageBox.Show("Edição inválida preencha todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Red;
                txtCpf.BackColor = Color.Red;
                txtRua.BackColor = Color.Red;
                txtNumero.BackColor = Color.Red;
                txtCidade.BackColor = Color.Red;
                txtPedido.BackColor = Color.Red;
                txtCodigo.BackColor = Color.Red;
                txtQuantidade.BackColor = Color.Red;
                txtValor.BackColor = Color.Red;
                txtDescricao.BackColor = Color.Red;
            }
            else
            {
                cliente.id = Convert.ToInt32(txtId.Text);
                cliente.cpf = txtCpf.Text;
                cliente.nome = txtNome.Text;
                cliente.rua = txtRua.Text;
                cliente.numero = txtNumero.Text;
                cliente.cidade = txtCidade.Text;
                cliente.numeroDePedido = txtPedido.Text;
                cliente.codigo = txtCodigo.Text;
                cliente.quantidade = txtQuantidade.Text;
                cliente.valor = txtValor.Text;
                cliente.descricao = txtDescricao.Text;

                clienteEditar.editar(cliente);

                MessageBox.Show("Pedido modificado com SUCESSO!");
                limparFormulario();
                listar();
            }

        }

        private void excluir(Cliente cliente)
        {
            cadastro clienteExluir = new cadastro();

            if (txtId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um cadastro da LISTA para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                limparFormulario();
            }
            else
            {
                cliente.id = Convert.ToInt32(txtId.Text);
                clienteExluir.excluir(cliente);

                limparFormulario();
                listar();
                MessageBox.Show("Cadastro excluido com sucesso!");
            }
        }


        private void limparFormulario()
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtPedido.Clear();
            txtCodigo.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtDescricao.Clear();

            txtNome.BackColor = Color.White;
            txtCpf.BackColor = Color.White;
            txtRua.BackColor = Color.White;
            txtNumero.BackColor = Color.White;
            txtCidade.BackColor = Color.White;
            txtPedido.BackColor = Color.White;
            txtCodigo.BackColor = Color.White;
            txtQuantidade.BackColor = Color.White;
            txtValor.BackColor = Color.White;
            txtDescricao.BackColor = Color.White;
        }


        private void GridMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gridMostrar.CurrentRow.Cells[0].Value.ToString();
            txtCpf.Text = gridMostrar.CurrentRow.Cells[1].Value.ToString();
            txtNome.Text = gridMostrar.CurrentRow.Cells[2].Value.ToString();
            txtRua.Text = gridMostrar.CurrentRow.Cells[3].Value.ToString();
            txtNumero.Text = gridMostrar.CurrentRow.Cells[4].Value.ToString();
            txtCidade.Text = gridMostrar.CurrentRow.Cells[5].Value.ToString();
            txtPedido.Text = gridMostrar.CurrentRow.Cells[6].Value.ToString();
            txtCodigo.Text = gridMostrar.CurrentRow.Cells[7].Value.ToString();
            txtQuantidade.Text = gridMostrar.CurrentRow.Cells[8].Value.ToString();
            txtValor.Text = gridMostrar.CurrentRow.Cells[9].Value.ToString();
            txtDescricao.Text = gridMostrar.CurrentRow.Cells[10].Value.ToString();
        }

        private void BtnSalvarAlt_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            editar(cliente);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            excluir(cliente);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            limparFormulario();
            Close();
        }
    }

}
