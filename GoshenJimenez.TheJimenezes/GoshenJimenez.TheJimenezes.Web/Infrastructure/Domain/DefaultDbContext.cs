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
    }
}
