﻿using Microsoft.EntityFrameworkCore;

namespace Products.Api;

public class ProductsDbContext : DbContext
{
    public ProductsDbContext(DbContextOptions<ProductsDbContext> options) 
    : base(options) {}
    
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }
}
