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
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8SGA7NI\\SQLEXPRESS;Initial Catalog=Tobeto4A;Integrated Security=True; Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);

            //Data Source=DESKTOP-8SGA7NI\SQLEXPRESS;Initial Catalog=Tobeto4A;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        }
    }
}
