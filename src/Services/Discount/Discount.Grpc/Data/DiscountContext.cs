﻿using Discount.Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data;

public class DiscountContext : DbContext
{

    public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon { Id = 1, ProductName = "Iphone X", Description = "Phone Discount", Amount = 150 },
            new Coupon { Id = 2, ProductName = "Samsung 20", Description = "Phone Discount", Amount = 50 }
            );
    }

    public DbSet<Coupon> Coupones { get; set; } = default!;
}
