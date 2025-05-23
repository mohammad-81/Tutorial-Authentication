﻿using Microsoft.EntityFrameworkCore;
using PersianResumeBuilder.Entities;

namespace PersianResumeBuilder.DataBase
{
    public class Sample_DbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InformationCustomerProfile> informationCustomerProfiles { get; set; }
        public DbSet<User> users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.Price)
                .HasPrecision(18, 4);
        }

    }
}
