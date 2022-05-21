using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ath_server.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATHNetworkDB
{
    class DataContext : IdentityDbContext
    {
        public DataContext()
        {}
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server= localhost; Database= ShopDB; Integrated Security=True;");
            }
        }
 
        public DbSet<Shop> Shops { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductInShop> ProductInShops { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDescription> OrdersDescriptions { get; set; } = null!;
    }
}
