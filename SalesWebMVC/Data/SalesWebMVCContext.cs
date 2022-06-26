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

        public DbSet<Cliente> Cliente { get; set; }
    
       public DbSet<Produto> Produto { get; set; }

       public DbSet<Pedido> Pedidos { get; set; }
    }
}
