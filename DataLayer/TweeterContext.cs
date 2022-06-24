using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;

namespace DataLayer
{
    public class TweeterContext : DbContext
    {
        public TweeterContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CDDUI2J;Database=Bozhidar;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);


        }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
