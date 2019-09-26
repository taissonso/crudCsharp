using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.Modelo;
using MySql.Data.MySqlClient;

namespace CRUD.Funções
{
    public class clienteSAVE : conexao
    {
        MySqlCommand comando = null;
       
     

        public void salvar(Cliente cliente)
        {
            try
            {
                Conectando();
                comando = new MySqlCommand("INSERT INTO cliente (cpf, nome, rua, numero, cidade, numeroDePedido, codigo, quantidade, valor, descricao) VALUES " +
                    "(@cpf, @nome, @rua, @numero, @cidade, @numeroDePedido, @codigo, @quantidade, @valor, @descricao)", conectando);

                comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@rua", cliente.rua);
                comando.Parameters.AddWithValue("@numero", cliente.numero);
                comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                comando.Parameters.AddWithValue("@numeroDePedido", cliente.numeroDePedido);
                comando.Parameters.AddWithValue("@codigo", cliente.codigo);
                comando.Parameters.AddWithValue("@quantidade", cliente.quantidade);
                comando.Parameters.AddWithValue("@valor", cliente.valor);
                comando.Parameters.AddWithValue("@descricao", cliente.descricao);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listar()
        {
            try
            {
                Conectando();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();

                comando = new MySqlCommand("SELECT * FROM cliente", conectando);
                
                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void editar(Cliente cliente)
        {
            try
            {
                Conectando();

                comando = new MySqlCommand("UPDATE cliente SET cpf = @cpf, nome = @nome, rua = @rua, numero =  @numero, cidade = @cidade, numeroDePedido = @numeroDePedido, codigo = @codigo, quantidade = @quantidade, valor = @valor, descricao = @descricao WHERE id = @id", conectando);

                comando.Parameters.AddWithValue("@id", cliente.id);
                comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@rua", cliente.rua);
                comando.Parameters.AddWithValue("@numero", cliente.numero);
                comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                comando.Parameters.AddWithValue("@numeroDePedido", cliente.numeroDePedido);
                comando.Parameters.AddWithValue("@codigo", cliente.codigo);
                comando.Parameters.AddWithValue("@quantidade", cliente.quantidade);
                comando.Parameters.AddWithValue("@valor", cliente.valor);
                comando.Parameters.AddWithValue("@descricao", cliente.descricao);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            { 
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluir (Cliente cliente)
        {
            try
            {
                Conectando();

                comando = new MySqlCommand("DELETE FROM cliente WHERE id = @id", conectando);

                comando.Parameters.AddWithValue("@id", cliente.id);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
            
    }
}
