using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CRUD.Modelo;
using CRUD.Intermedio;
using CRUD.Funções;
using CRUD.Formularios;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
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

        private void BotaoPesquisar_Click(object sender, EventArgs e)
        {
            limparFormulario();
            Pesquisar pesqForm = new Pesquisar();
            pesqForm.ShowDialog();
        }

        private void salvar (Cliente cliente)
        {

            cadastro clienteCadastrar = new cadastro();

            if(
                txtNome.Text.Trim() == string.Empty || txtCpf.Text.Trim() == string.Empty ||
                txtRua.Text.Trim() == string.Empty || txtNumero.Text.Trim() == string.Empty ||
                txtCidade.Text.Trim() == string.Empty || txtPedido.Text.Trim() == string.Empty ||
                txtCodigo.Text.Trim() == string.Empty || txtQuantidade.Text.Trim() == string.Empty ||
                txtValor.Text.Trim() == string.Empty || txtDescricao.Text.Trim() == string.Empty
                )
            {
                MessageBox.Show("Cadastro inválido preencha todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                clienteCadastrar.salvar(cliente);
                MessageBox.Show("Pedido feito com sucesso!");
                limparFormulario();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            salvar(cliente);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            limparFormulario();
            EditarForm editarForm = new EditarForm();
            editarForm.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
