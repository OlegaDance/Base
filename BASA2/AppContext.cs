using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BASA2
{
    internal class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppContext() : base("DefaultConnection") { }

    }

    internal class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsContext() : base("ProductsConnection") { }

    }

    internal class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderContext(): base("OrderConnection") { }
    }
 
}
