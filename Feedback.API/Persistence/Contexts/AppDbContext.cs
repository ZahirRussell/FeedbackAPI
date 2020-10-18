using Feedback.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.API.Persistence.Contexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Usres { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }        
        public DbSet<Like> Likes { get; set; }
        public DbSet<DisLike> DisLikes { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Entity<User>().Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Entity<User>().Property(p => p.UserName).IsRequired().HasMaxLength(100);
            builder.Entity<User>().Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.Entity<User>().HasMany(p => p.Comments).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            builder.Entity<User>().HasMany(p => p.Likes).WithOne(p => p.User).HasForeignKey(p => p.UserId);
            builder.Entity<User>().HasMany(p => p.Likes).WithOne(p => p.User).HasForeignKey(p => p.UserId);

            builder.Entity<Post>().ToTable("Posts");
            builder.Entity<Post>().HasKey(p => p.Id);
            builder.Entity<Post>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Post>().Property(p => p.Content).IsRequired().HasMaxLength(300);
            builder.Entity<Post>().HasMany(p => p.Comments).WithOne(p => p.Post).HasForeignKey(p => p.PostId);

            builder.Entity<Post>().HasData
            (
                new Post { Id = 100, Content = "Hello!" }, 
                new Post { Id = 101, Content = "Everyone" }
            );

            builder.Entity<Comment>().ToTable("Comments");
            builder.Entity<Comment>().HasKey(p => p.Id);
            builder.Entity<Comment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Comment>().Property(p => p.Content).IsRequired().HasMaxLength(500);
            builder.Entity<Comment>().HasMany(p => p.likes).WithOne(p => p.Comment).HasForeignKey(p => p.ComentId);
            builder.Entity<Comment>().HasMany(p => p.dislikes).WithOne(p => p.Comment).HasForeignKey(p => p.ComentId);


            builder.Entity<Like>().ToTable("Likes");
            builder.Entity<Like>().HasKey(p => p.Id);
            builder.Entity<Like>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Entity<DisLike>().ToTable("Likes");
            builder.Entity<DisLike>().HasKey(p => p.Id);
            builder.Entity<DisLike>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
