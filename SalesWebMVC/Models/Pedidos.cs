using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMVC.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
       
        public Produtos Produto { get; set; }
        public int ProdutoId { get; set; }

        public Clientes Cliente { get; set; }
        public int ClienteId { get; set; }
    
        public Status status { get; set; }

        public Pedidos()
        {

        }

        public Pedidos(int id, Produtos produto, Clientes cliente, Status status)
        {
            Id = id;
            Produto = produto;
            Cliente = cliente;
            this.status = status;
        }
    }
}
