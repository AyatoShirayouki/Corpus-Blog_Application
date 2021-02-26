using CorpusSMDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CorpusSMDemo.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<UserSharing> SharedPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public MyDbContext()
        {
            /*using (var context = new MyDbContext())
            {
                context.Database.Log = Console.Write;
            }*/
            Users = this.Set<User>();
            Admins = this.Set<Admin>();
            Posts = this.Set<Post>();
            SharedPosts = this.Set<UserSharing>();
            Comments = this.Set<Comment>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CorpusSM;User Id=alex;Password=rexibexi1;");
        }
    }
}
