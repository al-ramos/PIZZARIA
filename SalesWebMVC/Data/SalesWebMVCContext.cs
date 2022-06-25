using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMvcContext : DbContext 
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    
       public DbSet<Produtos> Produtos { get; set; }

       public DbSet<Pedidos> Pedidos { get; set; }
    }
}
