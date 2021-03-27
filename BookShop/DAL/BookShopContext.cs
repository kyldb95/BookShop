using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookShop.DAL
{
    public class BookShopContext : DbContext
    {
        public BookShopContext() : base("BookShopContext")
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}