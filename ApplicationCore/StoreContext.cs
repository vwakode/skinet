﻿using Microsoft.EntityFrameworkCore;
using DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=DESKTOP-KFAJACQ\SQLEXPRESS; Initial Catalog=skinet; persist security info=True; user id=vaibhav;password=1234");
                base.OnConfiguring(optionsBuilder);
            }
        }
        public DbSet<Product> Products { get; set; }
    }
}
