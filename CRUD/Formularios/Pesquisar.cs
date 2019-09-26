using CRUD.Funções;
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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
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

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
