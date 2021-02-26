﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothBazar.Entities;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        public CBContext() : base("ClothBazar")
        {
                
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
