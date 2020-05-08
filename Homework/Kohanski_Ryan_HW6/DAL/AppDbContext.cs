using System;
using Microsoft.EntityFrameworkCore;
using Kohanski_Ryan_HW6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Kohanski_Ryan_HW6.DAL
{
    //This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        //Add Dbsets here.   

        //The DbSet for Users is inherited from IdentityDbContext
        //The DbSet for AppUsers is called Users
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
