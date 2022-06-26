using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Clientes
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
            
       public ICollection<Pedido>   ListarPedidos {get; set; } = new List<Pedido>();
            
        public Clientes()
        {

        }

        public Clientes(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

       
        public void   AddPedidos(Pedido ped)
        {
            ListarPedidos.Add(ped);
        }

        public void RemovePedidos(Pedido ped)
        {
            ListarPedidos.Remove(ped);
        }
       
    }
}
