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
            
       public ICollection<Pedidos>   ListarPedidos {get; set; } = new List<Pedidos>();
            
        public Clientes()
        {

        }

        public Clientes(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

       
        public void   AddPedidos(Pedidos ped)
        {
            ListarPedidos.Add(ped);
        }

        public void RemovePedidos(Pedidos ped)
        {
            ListarPedidos.Remove(ped);
        }
       
    }
}
