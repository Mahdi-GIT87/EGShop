using EGShop.Datalayer.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGShop.Datalayer.Context
{
    public  class EGShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public EGShopContext(DbContextOptions<EGShopContext> options): base(options)
        {

        }
    }
}