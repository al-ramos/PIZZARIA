using SalesWebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Pedido FindById(int id)
        {
               
            return _context.Pedidos.Include(obj=> obj.Produto).FirstOrDefault(obj => obj.Id == id);
            
        }

        public void Remove(int? id)
        {
            var obj = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(obj);
            _context.SaveChanges();
        }

    }

}
