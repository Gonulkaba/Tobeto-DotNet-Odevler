﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8SGA7NI\\SQLEXPRESS;Initial Catalog=Tobeto4A2.Onion;Integrated Security=True; Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
