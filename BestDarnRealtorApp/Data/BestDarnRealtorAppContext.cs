using System;
using BestDarnRealtorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BestDarnRealtorApp.Data
{
    public class BestDarnRealtorAppContext : DbContext
    {
        public BestDarnRealtorAppContext(DbContextOptions<BestDarnRealtorAppContext> options)
            : base(options)
        {
        }
        public DbSet<Listing> Listing { get; set; }
        public DbSet<User> User { get; set; }

    }
}
