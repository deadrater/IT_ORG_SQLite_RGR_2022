﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IT_ORG_SQLite_RGR_2022.Database.Models;

namespace IT_ORG_SQLite_RGR_2022.Database
{
    public class _ContextDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        /*public DbSet<Customer> Customers { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<OrderedService> OrderedServices { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Service> Services { get; set; }*/

        public _ContextDb(DbContextOptions<_ContextDb> options) : base(options)
        {
            //Проверка существования БД
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Уникализация поля UserName
            modelBuilder.Entity<User>().HasAlternateKey(u => u.UserName);
        }
    }
}