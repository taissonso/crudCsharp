using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public class conexao
    {
        string conectar = "SERVER = localhost; DATABASE=crud; USERNAME = root; PASSWORD=;";
        protected MySqlConnection conectando = null;

        public void Conectando()
        {
            try
            {
                conectando = new MySqlConnection(conectar);
                conectando.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conectando = new MySqlConnection(conectar);
                conectando.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }
    }
}
