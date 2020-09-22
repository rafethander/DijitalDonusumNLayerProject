using Core.Models;
using Data.Configurations;
using Data.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products  { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(new Guid[] { Guid.Parse("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), Guid.Parse("a837cf99-e02a-4d4a-9a7e-44f0b6166c24") }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new Guid[] { Guid.Parse("ee4611dd-82b1-4c30-94e1-579c9b7b2820"), Guid.Parse("a837cf99-e02a-4d4a-9a7e-44f0b6166c24") }));
        }
    }
}
