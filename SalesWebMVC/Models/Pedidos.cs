using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Pedidos
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int ClienteId { get; set; }

        public int Sta_Pedido { get; set; }

        public int Valor { get; set; }
    }
}
