﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza.Application.Interfaces;
using Pizza.Domain.Entity;
using Pizza.Domain.Users;
using Pizza.Persistent.EntityTypeConfiguration;
namespace Pizza.Persistent.EntityTypeContext
{
    public class Context : IdentityDbContext<User, Role, int>, IContext
    {
        public Context(DbContextOptions<Context> contextOptions) : base(contextOptions) { }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Cart>? Carts { get; set; }
        public override DbSet<User>? Users { get; set; }


        protected override void OnModelCreating(ModelBuilder option)
        {
            _ = option.ApplyConfiguration(new UserOptionConfiguration());
            _ = option.ApplyConfiguration(new ProductOptionConfiguration());
            _ = option.ApplyConfiguration(new CartOptionConfiguration());
            _ = option.ApplyConfiguration(new UserRoleOptionConfiguration());
            _ = option.ApplyConfiguration(new UserTokensOptionConfiguration());

            base.OnModelCreating(option);

        }
    }
}
