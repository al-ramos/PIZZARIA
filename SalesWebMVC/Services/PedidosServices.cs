using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class PedidoService
    {
        private readonly SalesWebMvcContext _context;

        public PedidoService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Pedido> FindAll()
        {
            return _context.Pedidos.ToList();
        }

        public void Insert(Pedido obj)
        {
            obj.Cliente = _context.Clientes.First();
            obj.Produto = _context.Produto.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }


}
