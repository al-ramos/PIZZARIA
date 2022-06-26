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
            //    _context.Produto.Any() ||
            //    _context.Pedidos.Any()) ;
            //{
            //    return;
            //}

            Clientes c1 = new Clientes(1, "Ana", "ana@gmail.com");
            Clientes c2 = new Clientes(2, "Thais", "thais@gmail.com");

            Produto p1 = new Produto(1, "Margarita", 45.5);
            Produto p2 = new Produto(2, "Portuguesa", 50.15);

            Pedido ped1 = new Pedido(1, p1,c1, Status.Pendente);
            Pedido ped2 = new Pedido(2, p2, c2, Status.Pronto);

            _context.Clientes.AddRange(c1, c2);
            _context.Produto.AddRange(p1, p2);
            _context.Pedidos.AddRange(ped1, ped2);

            _context.SaveChanges();

        }
            
    }
}
