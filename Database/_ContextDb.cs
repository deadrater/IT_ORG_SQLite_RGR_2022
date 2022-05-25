using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Services;

namespace IT_ORG_SQLite_RGR_2022.Database
{
    public class _ContextDb : DbContext
    {
        CustomExceptions ex = new CustomExceptions();

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Good> Goods { get; set; }
        //public DbSet<OrderedService> OrderedServices { get; set; }
        //public DbSet<Orders> Orders { get; set; }
        //public DbSet<Service> Services { get; set; }

        public _ContextDb(DbContextOptions<_ContextDb> options) : base(options)
        {
            try
            {
                //Проверка существования БД
                Database.EnsureCreated();
            }
            catch(Exception e)
            {
                ex.ThrowNewException("DATABASE ERROR", "There is some kind of error with the database...");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                //Уникализация поля UserName
                modelBuilder.Entity<User>().HasAlternateKey(u => u.UserName);
            }
            catch(Exception e)
            {
                ex.ThrowNewException("DATABASE ERROR","There is error with creating database...");
            }
        }
    }
}