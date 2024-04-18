using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    // Veritabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8SGA7NI\\SQLEXPRESS;Initial Catalog=Tobeto4A2;Integrated Security=True; Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasOne(i => i.Category);
            modelBuilder.Entity<Product>().Property(i => i.Name).HasColumnName("Name")
                .HasMaxLength(50);

            // Seed Data
            Category category = new Category(1, "Giyim");
            Category category1 = new Category(2, "Elektronik");
            Product product = new Product(1, "Kazak", 500, 50, 1);

            modelBuilder.Entity<Category>().HasData(category,category1);
            modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }
    }
}
