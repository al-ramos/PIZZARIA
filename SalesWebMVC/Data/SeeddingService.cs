using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeeddingService
    {
        private SalesWebMvcContext _context;

        public SeeddingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //if (_context.Clientes.Any() ||
            //    _context.Produtos.Any() ||
            //    _context.Pedidos.Any()) ;
            //{
            //    return;
            //}

            Clientes c1 = new Clientes(1, "Ana", "ana@gmail.com");
            Clientes c2 = new Clientes(2, "Thais", "thais@gmail.com");

            Produtos p1 = new Produtos(1, "Margarita", 45.5);
            Produtos p2 = new Produtos(2, "Portuguesa", 50.15);

            Pedidos ped1 = new Pedidos(1, p1,c1, Status.Pendente);
            Pedidos ped2 = new Pedidos(2, p2, c2, Status.Pronto);

            _context.Clientes.AddRange(c1, c2);
            _context.Produtos.AddRange(p1, p2);
            _context.Pedidos.AddRange(ped1, ped2);

            _context.SaveChanges();

        }
            
    }
}
