using Microsoft.EntityFrameworkCore;
using ForumApi.Domain.Entities;

namespace ForumApi.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Post> Posts { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Reply> Replies { get; set; }
    }
}