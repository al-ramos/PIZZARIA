using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SalesWebMVC.Models
{
    public class Pedido
    {
        public int Id { get; set; }
       
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public Clientes Cliente { get; set; }
        public int ClienteId { get; set; }
    
        public Status status { get; set; }

        public Pedido()
        {

        }

        public Pedido(int id, Produto produto, Clientes cliente, Status status)
        {
            Id = id;
            Produto = produto;
            Cliente = cliente;
            this.status = status;
        }
    }
}
