using ETİCARET.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETİCARET.Context
{
    public class DataContext:DbContext
    {

        public  DataContext():base("dataConnection")
        {
            
        }
        public DbSet<Product> products{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
    
}