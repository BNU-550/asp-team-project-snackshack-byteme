using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Snack_Shack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snack_Shack.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
