using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaShop.ProtoTypes;

namespace PizzaShop.Data
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext (DbContextOptions<PizzaShopContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaShop.ProtoTypes.Customer> Customer { get; set; }

        public DbSet<PizzaShop.ProtoTypes.Order> Order { get; set; }

        public DbSet<PizzaShop.ProtoTypes.PizzaOrder> PizzaOrder { get; set; }

        public DbSet<PizzaShop.ProtoTypes.Pizza> Pizza { get; set; }
    }
}
