using BlogAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Data
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        
        }
        
        //dbset

        public DbSet<Post> Posts { get; set; }
    }  
}

