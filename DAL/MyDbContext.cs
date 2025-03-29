using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
      
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}
