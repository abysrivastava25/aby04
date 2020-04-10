using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Entity.Models
{
    public class CodeFirstContext:DbContext
    {
        public CodeFirstContext()
        { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CodeFirst;Trusted_Connection=True;"); }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
