using Microsoft.EntityFrameworkCore;

namespace spectrolyte.tv.Models
{
    public class BlogPostContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }  

        public BlogPostContext(DbContextOptions<BlogPostContext> options)
            : base(options)
        {
        }
    }
}