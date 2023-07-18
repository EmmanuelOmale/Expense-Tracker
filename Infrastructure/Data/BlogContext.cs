using ApplicationCore.Entities;
using Infrastructure.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
