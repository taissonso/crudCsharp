using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome{ get; set; }

        public string rua { get; set; }
        public string numero { get; set; }
        public string cidade { get; set; }

        public string numeroDePedido { get; set; }

        public string codigo { get; set; }

        public string quantidade { get; set; }

        public string valor { get; set; }

        public string descricao { get; set; }




    }
}
