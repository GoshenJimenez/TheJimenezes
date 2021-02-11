using GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoshenJimenez.TheJimenezes.Web.Infrastructure.Domain
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
   : base(options)
        { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Column> columns = new List<Column>()
            {
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                    Title = "Projects",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.TechAndProjects
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be201"),
                    Title = "Programming",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.TechAndProjects
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be202"),
                    Title = "Tech Talk",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.TechAndProjects
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be203"),
                    Title = "Parallax",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Literary
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be204"),
                    Title = "Parallax II",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Literary
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be205"),
                    Title = "Travel Logs",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.TravelAndReviews
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be206"),
                    Title = "Food Reviews",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.TravelAndReviews
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be207"),
                    Title = "Fambam!",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Gallery
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be208"),
                    Title = "Xiah's World",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Gallery
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be209"),
                    Title = "Ayu's Corner",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Gallery
                },
                new Column()
                {
                    Id = Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be210"),
                    Title = "Sights and Visions",
                    SubTitle = "",
                    IconUrl = "",
                    ColumnType = Enums.ColumnType.Gallery
                }
            };

            modelBuilder.Entity<Column>()
               .HasData(columns);


            List<Post> posts = new List<Post>()
            {
                new Post()
                {
                    Id = Guid.Parse("13febb22-f596-4b1e-b0a8-b11ad54be200"),
                    Title = "Project 1",
                    SubTitle = "Project 1",
                    Author = "Goshen",
                    ColumnId =  Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                    Type = Enums.PostType.Article
                },new Post()
                {
                    Id = Guid.Parse("13febb22-f596-4b1e-b0a8-b11ad54be201"),
                    Title = "Project 2",
                    SubTitle = "Project 2",
                    Author = "Tere",
                    ColumnId =  Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                    Type = Enums.PostType.Article
                },new Post()
                {
                    Id = Guid.Parse("13febb22-f596-4b1e-b0a8-b11ad54be202"),
                    Title = "Project 3",
                    SubTitle = "Project 3",
                    Author = "Aya",
                    ColumnId =  Guid.Parse("12febb22-f596-4b1e-b0a8-b11ad54be200"),
                    Type = Enums.PostType.Article
                }
            };

            modelBuilder.Entity<Post>()
                .HasData(posts);
        }
    }
}
