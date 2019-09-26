using CRUD.Funções;
using CRUD.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace CRUD.Intermedio
{
    public class cadastro
    {
        clienteSAVE novo = new clienteSAVE();


        public void salvar(Cliente cliente)
        {
            try
            {
                novo.salvar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = novo.listar();

                return dt;
            }
            catch (Exception erro) { 
            
                throw erro;
            }
        }

        public void editar(Cliente cliente)
        {
            try
            {
                novo.editar(cliente);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void excluir(Cliente cliente)
        {
            try
            {
                novo.excluir(cliente);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
