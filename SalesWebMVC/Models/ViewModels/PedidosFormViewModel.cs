using System;
using System.Collections.Generic;


namespace SalesWebMVC.Models.ViewModels
{
    public class PedidosFormViewModel
    {
       public Pedido pedidos { get; set; }
 
        public ICollection<Produto> Produtos { get; set; }


        public ICollection<Cliente> Clientes { get; set; }


    }
}
