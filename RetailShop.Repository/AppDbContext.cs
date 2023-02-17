﻿using Microsoft.EntityFrameworkCore;
using RetailShop.Repository.Enitities;

namespace RetailShop.Repository
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }        

    }
}