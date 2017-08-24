using Microsoft.EntityFrameworkCore;

namespace spectrolyte.tv.Models
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext(DbContextOptions<BlogPostContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}