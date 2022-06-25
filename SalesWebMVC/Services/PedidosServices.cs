using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class PedidosService
    {
        private readonly SalesWebMvcContext _context;

        public PedidosService(SalesWebMvcContext context)
        {
            _context = context;

        }

        public List<Pedidos> FindAll()
        {
            return _context.Pedidos.ToList();
        }

        public void Insert(Pedidos obj)
        {
            obj.Cliente = _context.Clientes.First();
            obj.Produto = _context.Produtos.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }


}
