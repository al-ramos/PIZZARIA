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
            if (_context.Cliente.Any() ||
                _context.Produto.Any() ||
                _context.Pedidos.Any()) ;
            {
                return;
            }

            Cliente c1 = new Cliente(1, "Ana", "ana@exempo.com");
            Cliente c2 = new Cliente(2, "Thais", "thais@exemplo.com");

            Produto p1 = new Produto(1, "Pizza de Zuccini e Muçarela", 50.0);
            Produto p2 = new Produto(2, "Pizza de Muçarela e Camarão", 50.0);

            Pedido ped1 = new Pedido(1, p1,c1, "Em Andamento");
            Pedido ped2 = new Pedido(2, p2, c2, "Pronto");

            _context.Cliente.AddRange(c1, c2);
            _context.Produto.AddRange(p1, p2);
            _context.Pedidos.AddRange(ped1, ped2);

            _context.SaveChanges();

        }
            
    }
}
